using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class RegistrationHandle : Form
    {
        Registration registration;
        TextBox textBoxUsername;
        TextBox textBoxEmail;
        TextBox textBoxPassword;
        TextBox textBoxConfirmPassword;
        Button SignIn;
        Button SignUp;

        public string username;
        string email;
        string password;
        string confirmPassword;

        bool UsernameFilled = false;
        bool EmailFilled = false;
        bool PasswordFilled = false;
        bool ConfirmPasswordFilled = false;
        public RegistrationHandle()
        {
        }
        public void getRegistrationForm(Registration registration_, TextBox textBoxUsername_, TextBox textBoxEmail_,
            TextBox textBoxPassword_, TextBox textBoxConfirmPassword_, Button SignIn_, Button SignUp_)
        {
            registration = registration_;
            textBoxUsername = textBoxUsername_;
            textBoxEmail = textBoxEmail_;
            textBoxPassword = textBoxPassword_;
            textBoxConfirmPassword = textBoxConfirmPassword_;
            SignIn = SignIn_;
            SignUp = SignUp_;
        }

        public void getRegistrationData(string username_, string email_, string password_, string confirmPassword_)
        {
            username = username_;
            email = email_;
            password = password_;
            confirmPassword = confirmPassword_;
        }

        public void getLoginData(string username_, string email_, string password_)
        {
            username = username_;
            email = email_;
            password = password_;
        }

        public void textBoxUsernameCheck()
        {
            if (textBoxUsername.Text != "")
            {
                UsernameFilled = true;
                this.checkIfSignInIsEnable();
            }
            else
            {
                UsernameFilled = false;
                this.SignIn.Enabled = false;
                this.SignUp.Enabled = false;
            }
        }

        public void textBoxEmailCheck()
        {
            if (textBoxEmail.Text != "")
            {
                EmailFilled = true;
                this.checkIfSignInIsEnable();
            }
            else
            {
                EmailFilled = false;
                this.SignIn.Enabled = false;
                this.SignUp.Enabled = false;
            }
        }

        public void textBoxPasswordCheck()
        {
            if (textBoxPassword.Text != "")
            {
                PasswordFilled = true;
                this.checkIfSignInIsEnable();
            }
            else
            {
                PasswordFilled = false;
                this.SignIn.Enabled = false;
                this.SignUp.Enabled = false;
            }
        }

        public void textBoxConfirmPasswordCheck()
        {
            if (textBoxConfirmPassword.Text != "")
            {
                ConfirmPasswordFilled = true;
                this.checkIfSignUpIsEnable();

            }
            else
            {
                ConfirmPasswordFilled = false;
                this.SignUp.Enabled = false;
            }
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
            if (this.SignIn.Enabled == true && ConfirmPasswordFilled == true)
            {
                this.SignUp.Enabled = true;
            }
            else
            {
                this.SignUp.Enabled = false;
            }
        }

        public void checkIfLoginDataIsCorrect()
        {
            using (var db = new CodeFirstContext())
            {
                bool correct = false;
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser != null && foundUser.Email == email && foundUser.Password == password)
                {
                    MessageBox.Show("Logged in correctly.");
                    this.openHomeForm();
                }
                else if(foundUser == null)
                {
                    MessageBox.Show("There is no user with the given username.");
                }
                else
                {
                    MessageBox.Show("Entered data is incorrect. Please try again.");
                }
            }
        }

        public void checkIfRegistrationDataIsCorrect()
        {
            int error = 0;

            //user with this username already exists
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser != null) { error = 1; }
            }

            //password and confirmPassword are different
            if (password != confirmPassword) { error = 2; }

            if (error == 0)
            {
                this.addNewUser();
                MessageBox.Show("User added.");
                this.openHomeForm();
            }
            else if (error == 1)
            {
                MessageBox.Show("This username is taken. Please select a differnet one.");
            }
            else if (error == 2)
            {
                MessageBox.Show("Entered passwords are not the same. Please try again.");
            }
        }


        public void openHomeForm()
        {
            registration.Hide();
            Home home = new Home(username);
            home.ShowDialog();
            registration.Close();
        }

        public void addNewUser()
        {
            using (var db = new CodeFirstContext())
            {
                db.Users.Add(new User()
                {
                    Id = 1,
                    Name = username,
                    Email = email,
                    Password = password,
                    Role = "user"
                });
                db.SaveChanges();
            }
        }

    }
}
