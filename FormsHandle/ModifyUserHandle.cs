using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class ModifyUserHandle : Form
    {
        ModifyUser modifyUserForm;
        Button returnButton;
        Button changeButton;
        TextBox textBoxUsername;
        TextBox textBoxEmail;
        TextBox textBoxPassword;
        CheckedListBox roleListBox;

        string adminUsername;
        User userToModify;
        public void getModifyUserForm(ModifyUser modifyuserForm_, Button returnButton_, Button changeButton_,
            string adminUsername_, User userToModify_, TextBox textBoxUsername_, TextBox textBoxEmail_, TextBox textBoxPassword_)
        {
            modifyUserForm = modifyuserForm_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            adminUsername = adminUsername_;
            userToModify = userToModify_;
            textBoxUsername = textBoxUsername_;
            textBoxEmail = textBoxEmail_;
            textBoxPassword = textBoxPassword_;
            this.showUser();

        }

        public void showUser()
        {
            textBoxUsername.Text = userToModify.Name;
            textBoxEmail.Text = userToModify.Email;
            textBoxPassword.Text = userToModify.Password;

        }


        public void returnToHomePanel()
        {
            modifyUserForm.Hide();
            Home home = new Home(adminUsername);
            home.ShowDialog();
            modifyUserForm.Close();
        }
        
        public void usernameChanged()
        {
            if (textBoxUsername.Text == userToModify.Name)
            {
                changeButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = true;
            }
        }


        public void emailChanged()
        {
            if (textBoxEmail.Text == userToModify.Email)
            {
                changeButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = true;
            }
        }

        public void passwordChanged()
        {
            if (textBoxPassword.Text == userToModify.Password)
            {
                changeButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = true;
            }
        }

        public void changeUserData()
        {
            using(var db = new CodeFirstContext())
            {
                var user = db.Users.FirstOrDefault(u => u == userToModify);
                user.Name = textBoxUsername.Text;
                user.Email = textBoxEmail.Text;
                user.Password = textBoxPassword.Text;
                db.SaveChanges();
            }
            MessageBox.Show("User data changed.");
            this.returnToHomePanel();
        }

    }
}
