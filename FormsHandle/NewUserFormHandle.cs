using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class NewUserFormHandle : Form
    {
        NewUserForm userForm;
        string username;
        CheckedListBox listBoxRoles;
        TextBox textBoxUsername;
        TextBox textBoxPassword;
        TextBox textBoxEmail;
        Button addButton;

        bool usernameFilled = false;
        bool emailFilled = false;
        bool passwordFilled = false;
        public void getNewUserForm(NewUserForm userForm_, string username_, CheckedListBox listBoxRoles_,
            TextBox textBoxUsername_, TextBox textBoxEmail_, TextBox textBoxPassword_, Button addButton_)
        {
            userForm = userForm_;
            username = username_;
            listBoxRoles = listBoxRoles_;
            textBoxUsername = textBoxUsername_;
            textBoxPassword = textBoxPassword_;
            textBoxEmail = textBoxEmail_;
            addButton = addButton_;
            this.showRoles();
        }

        public void showRoles()
        {
            using (var db = new CodeFirstContext())
            {
                var allRoles = db.Roles.ToList();
                foreach (var role in allRoles)
                {
                    listBoxRoles.Items.Add(role.Name);
                }
            }
        }

        public void textBoxUsernameCheck()
        {
            usernameFilled = false;
            if(textBoxUsername.Text != "")
            {
                usernameFilled = true;
            }
            this.checkIfAllFilled();
        }

        public void texBoxEmailCheck()
        {
            emailFilled = false;
            if(textBoxEmail.Text != "")
            {
                emailFilled = true;
            }
            this.checkIfAllFilled();
        }

        public void textBoxPasswordCheck()
        {
            passwordFilled = false;
            if(textBoxPassword.Text != "")
            {
                passwordFilled = true;
            }
            this.checkIfAllFilled();
        }

        public void allowOnlyOneItemCheck(ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listBoxRoles.Items.Count; ++ix)
                if (ix != e.Index) listBoxRoles.SetItemChecked(ix, false);
            this.checkIfAllFilled();
        }

        public void checkIfAllFilled()
        {
            if(usernameFilled && emailFilled && passwordFilled && listBoxRoles.SelectedItem != null)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        public void returnToHomePanel()
        {
            userForm.Hide();
            Home home = new Home(this.username);
            home.ShowDialog();
            userForm.Close();
        }

        public int checkIfRegistrationDataIsCorrect()
        {
            int error = 0;

            //user with this username already exists
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == textBoxUsername.Text);
                if (foundUser != null) { error = 1; }
            }
            return error;
        }

        public void addNewUser()
        {
            if(this.checkIfRegistrationDataIsCorrect() == 1)
            {
                MessageBox.Show("User with this username already exists.");
                return;
            }
            string password = sha256_hash(textBoxPassword.Text); 
            using (var db = new CodeFirstContext())
            {
                db.Users.Add(new User()
                {
                    Name = textBoxUsername.Text,
                    Email = textBoxEmail.Text,
                    Password = password,
                    Role = listBoxRoles.SelectedItem.ToString()
                });   
                db.SaveChanges();
            }
            MessageBox.Show("User added.");
            this.returnToHomePanel();
        }

        public String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }
    }
}
