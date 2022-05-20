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

        public void getModifyUserForm(ModifyUser modifyuserForm_, Button returnButton_, Button changeButton_,
            string adminUsername_, TextBox textBoxUsername_, TextBox textBoxEmail_, TextBox textBoxPassword_)
        {
            modifyUserForm = modifyuserForm_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            adminUsername = adminUsername_;
            textBoxUsername = textBoxUsername_;
            textBoxEmail = textBoxEmail_;
            textBoxPassword = textBoxPassword_;
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

        }


        public void emailChanged()
        {

        }

        public void passwordChanged()
        {

        }

        public void changeUserData()
        {

        }

    }
}
