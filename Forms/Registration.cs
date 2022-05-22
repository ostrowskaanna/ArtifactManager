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
       
        
        public Registration()
        {
            InitializeComponent();
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.PasswordChar = '*';
            registrationHandle.getRegistrationForm(this, this.textBoxUsername, this.textBoxEmail, 
                this.textBoxPassword, this.textBoxConfirmPassword, this.SignIn, this.SignUp);
        }


        private void SignUp_Click(object sender, EventArgs e)
        {
            registrationHandle.getRegistrationData(this.textBoxUsername.Text, this.textBoxEmail.Text,
                this.textBoxPassword.Text, this.textBoxConfirmPassword.Text);
            registrationHandle.checkIfRegistrationDataIsCorrect();

        }
    

        private void SignIn_Click(object sender, EventArgs e)
        {
            registrationHandle.getLoginData(this.textBoxUsername.Text, this.textBoxEmail.Text, this.textBoxPassword.Text);
            registrationHandle.checkIfLoginDataIsCorrect();
        }

        private void textBoxUsernameCheck(object sender, EventArgs e)
        {
            registrationHandle.textBoxUsernameCheck();
        }

        private void textBoxEmailCheck(object sender, EventArgs e)
        {
            registrationHandle.textBoxEmailCheck();
            
        }

        private void textBoxPassowrdCheck(object sender, EventArgs e)
        {
            registrationHandle.textBoxPasswordCheck();
        }

        private void textBoxConfirmPasswordCheck(object sender, EventArgs e)
        {
            registrationHandle.textBoxConfirmPasswordCheck();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            registrationHandle.finish();
        }
    }
}
