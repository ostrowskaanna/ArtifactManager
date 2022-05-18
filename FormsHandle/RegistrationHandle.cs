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

        public bool checkIfLoginDataIsCorrect()
        {
            using (var db = new CodeFirstContext())
            {
                var foundUser = db.Users.FirstOrDefault(c => c.Name == username);
                if (foundUser == null) { return false; }
                else if(foundUser.Email == email && foundUser.Password == password) { return true; }
                else { return false; }
            }
            
        }

        public int checkIfRegistrationDataIsCorrect()
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
            }
            return error;
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
