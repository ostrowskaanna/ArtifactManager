using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.FormsHandle
{
    public class RegistrationHandle
    {
        Registration registration = null;
        string username;
        string email;
        string password;
        string confirmPassword;

        public RegistrationHandle()
        {
        }
        public void getRegistrationForm(Registration registration_)
        {
            registration = registration_;
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

        public void openHomeForm()
        {
            registration.Hide();
            Home home = new Home();
            home.ShowDialog();
            registration.Close();
        }

        public void addNewUser()
        {
            
        }

    }
}
