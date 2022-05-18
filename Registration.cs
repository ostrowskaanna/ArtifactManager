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
            registrationHandle.getRegistrationData(this.textBoxUsername.Text, this.textBoxEmail.Text,
                this.textBoxPassword.Text, this.textBoxConfirmPassword.Text);
            int error = registrationHandle.checkIfRegistrationDataIsCorrect();
            if(error == 1)
            {
                MessageBox.Show("This username is taken. Please select a differnet one.");
            }
            else if(error == 2)
            {
                MessageBox.Show("Entered passwords are not the same. Please try again.");
            }
            else
            {
                MessageBox.Show("User added.");
                registrationHandle.openHomeForm();
            }

        }
    

        private void SignIn_Click(object sender, EventArgs e)
        {
            registrationHandle.getLoginData(this.textBoxUsername.Text, this.textBoxEmail.Text, this.textBoxPassword.Text);
            bool correct = registrationHandle.checkIfLoginDataIsCorrect();
            if (correct)
            {
                MessageBox.Show("Logged in correctly.");
                registrationHandle.openHomeForm();
            }
            else
            {
                MessageBox.Show("Entered data is incorrect. Please try again.");
            }
        }

        private void textBoxUsernameCheck(object sender, EventArgs e)
        {
            if(textBoxUsername != null) 
            { 
                UsernameFilled = true;
            }
            this.checkIfSignInIsEnable();
        }

        private void textBoxEmailCheck(object sender, EventArgs e)
        {
            if(textBoxEmail != null) 
            { 
                EmailFilled = true;
            }
            this.checkIfSignInIsEnable();
        }

        private void textBoxPassowrdCheck(object sender, EventArgs e)
        {
            if(textBoxPassword != null) 
            { 
                PasswordFilled = true;
            }
            this.checkIfSignInIsEnable();
        }

        private void textBoxConfirmPasswordCheck(object sender, EventArgs e)
        {
            if(textBoxConfirmPassword != null) 
            { 
                ConfirmPasswordFilled = true;
            }
            this.checkIfSignUpIsEnable();
        }

        private void checkIfSignInIsEnable()
        {
            if (UsernameFilled == true && EmailFilled == true && PasswordFilled == true)
            {
                this.SignIn.Enabled = true;
            }
            else
            {
                this.SignIn.Enabled = false;
            }
        }

        private void checkIfSignUpIsEnable()
        {
            if(this.SignIn.Enabled == true && ConfirmPasswordFilled == true)
            {
                this.SignUp.Enabled = true;
            }
            else
            {
                this.SignUp.Enabled = false;
            }
        }

    }
}
