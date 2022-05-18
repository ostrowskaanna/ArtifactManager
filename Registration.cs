using ArtifactManager.FormsHandle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager
{
    public partial class Registration : Form
    {
        RegistrationHandle registrationHandle = new RegistrationHandle();
        bool UsernameFilled = false;
        bool EmailFilled = false;
        bool PasswordFilled = false;
        bool ConfirmPasswordFilled = false;

        public Registration()
        {
            InitializeComponent();
            registrationHandle.getRegistrationForm(this);
        }


        private void SignUp_Click(object sender, EventArgs e)
        {
            registrationHandle.getRegistrationData(this.textBoxUsername.ToString(), this.textBoxEmail.ToString(),
                this.textBoxPassword.ToString(), this.textBoxConfirmPassword.ToString());
            registrationHandle.addNewUser();
            registrationHandle.openHomeForm();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            registrationHandle.getLoginData(this.textBoxUsername.ToString(), this.textBoxEmail.ToString(), this.textBoxPassword.ToString());
            registrationHandle.openHomeForm();
        }

        private void textBoxUsernameCheck(object sender, EventArgs e)
        {
            if(textBoxUsername != null) 
            { 
                UsernameFilled = true;
                this.checkIfSignInIsEnable();
            }
        }

        private void textBoxEmailCheck(object sender, EventArgs e)
        {
            if(textBoxEmail != null) 
            { 
                EmailFilled = true;
                this.checkIfSignInIsEnable();
            }
        }

        private void textBoxPassowrdCheck(object sender, EventArgs e)
        {
            if(textBoxPassword != null) 
            { 
                PasswordFilled = true;
                this.checkIfSignInIsEnable();
            }
        }

        private void textBoxConfirmPasswordCheck(object sender, EventArgs e)
        {
            if(textBoxConfirmPassword != null) 
            { 
                ConfirmPasswordFilled = true;
                this.checkIfSignUpIsEnable();
            }
        }

        private void checkIfSignInIsEnable()
        {
            if (UsernameFilled == true && EmailFilled == true && PasswordFilled == true)
            {
                this.SignIn.Enabled = true;
            }
        }

        private void checkIfSignUpIsEnable()
        {
            if(this.SignIn.Enabled == true && ConfirmPasswordFilled == true)
            {
                this.SignUp.Enabled = true;
            }
        }

    }
}
