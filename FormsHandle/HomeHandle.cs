using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class HomeHandle : Form
    {
        Home home;
        Label label1;
        Label label2;
        TextBox textBoxOldPassword;
        TextBox textBoxNewPassword;
        Button confirmButton;

        string username;

        bool oldPasswordFiled = false;
        bool newPasswordFilled = false;

        public void getHomeForm(Home home_, Label label1_, Label label2_, 
            TextBox textBoxOldPassword_, TextBox textBoxNewPasword_, Button confirmButton_, string username_)
        {
            home = home_;
            label1 = label1_;
            label2 = label2_;
            textBoxOldPassword = textBoxOldPassword_;
            textBoxNewPassword = textBoxNewPasword_ ;
            confirmButton = confirmButton_;
            username = username_;
            MessageBox.Show(username);
            textBoxOldPassword.PasswordChar = '*';
            textBoxNewPassword.PasswordChar = '*';

            
        }
        
        public void showProfileDetails()
        {
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser != null)
                {
                    this.label2.Text = "Email: " + foundUser.Email;
                }
            }
            this.label1.Text = "Username: " + username;
            this.label1.Visible = true;
            this.label2.Visible = true;
        }

        public void changePassword()
        {
            this.label1.Text = "Enter old password:";
            this.label2.Text = "Enter new password";
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.textBoxOldPassword.Visible = true;
            this.textBoxNewPassword.Visible = true;
            this.confirmButton.Visible = true;
        }
    
        public void textBoxOldPasswordCheck()
        {
            if (textBoxOldPassword.Text != "")
            {
                oldPasswordFiled = true;
                if (newPasswordFilled == true)
                {
                    confirmButton.Enabled = true;
                }
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }
    
        public void textBoxNewPasswordCheck()
        {
            if (textBoxNewPassword.Text != "")
            {
                newPasswordFilled = true;
                if (oldPasswordFiled == true)
                {
                    confirmButton.Enabled = true;
                }
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        public void confirmButtonClick()
        {
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if(foundUser.Email == textBoxOldPassword.Text)
                {
                    
                }
            }
        }

    }
}
