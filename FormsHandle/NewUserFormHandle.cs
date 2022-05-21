using System;
using System.Collections.Generic;
using System.Linq;
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
                var allUsers = db.Users.ToList();
                foreach (var user in allUsers)
                {
                    if (!listBoxRoles.Items.Contains(user.Role))
                    {
                        listBoxRoles.Items.Add(user.Role);
                    }
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

        public void addNewUser()
        {
            using (var db = new CodeFirstContext())
            {
                db.Users.Add(new User()
                {
                    Id = 1,
                    Name = textBoxUsername.Text,
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                    Role = (string)listBoxRoles.SelectedItem
                });  
                db.SaveChanges();
            }
            MessageBox.Show("User added.");
            this.returnToHomePanel();
        }
    }
}
