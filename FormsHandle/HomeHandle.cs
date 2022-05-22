using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.Forms;

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
        Label Info;
        ListBox listBox;
        Label text;

        string username;

        bool oldPasswordFiled = false;
        bool newPasswordFilled = false;

        public void getHomeForm(Home home_, Label label1_, Label label2_,
            TextBox textBoxOldPassword_, TextBox textBoxNewPasword_, Button confirmButton_, string username_,
            Label Info_, ListBox listBox_, Label text_)
        {
            home = home_;
            label1 = label1_;
            label2 = label2_;
            textBoxOldPassword = textBoxOldPassword_;
            textBoxNewPassword = textBoxNewPasword_;
            confirmButton = confirmButton_;
            username = username_;
            textBoxOldPassword.PasswordChar = '*';
            textBoxNewPassword.PasswordChar = '*';
            Info = Info_;
            listBox = listBox_;
            text = text_;
        }

        public void showProfileDetails()
        {
            this.listBox.Visible = false;
            this.text.Visible = false;
            this.Info.Visible = true;
            this.textBoxOldPassword.Visible = false;
            this.textBoxNewPassword.Visible = false;
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
            this.listBox.Visible = false;
            this.text.Visible = false;
            this.Info.Visible = true;
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
                if (foundUser.Password == textBoxOldPassword.Text)
                {
                    foundUser.Password = textBoxNewPassword.Text;
                    MessageBox.Show("Password changed.");
                    textBoxNewPassword.Text = "";
                    textBoxOldPassword.Text = "";
                    confirmButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You entered wrong old password. Please try again.");
                }
                db.SaveChanges();
            }
        }

        public void logOut()
        {
            home.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            home.Close();
        }

        public void modifyUser()
        {
            home.Hide();
            EditUser editUserForm = new EditUser(this.username);
            editUserForm.ShowDialog();
            home.Close();
        }

        public void addNewUser()
        {
            home.Hide();
            NewUserForm newUserForm = new NewUserForm(this.username);
            newUserForm.ShowDialog();
            home.Close();
        }

        public void seeAllUsers()
        {
            this.Info.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.textBoxOldPassword.Visible = false;
            this.confirmButton.Visible = false;
            this.listBox.Visible = true;
            this.text.Visible = true;
            this.text.Text = "Here are all the users:";

            listBox.Items.Clear();
            using (var db = new CodeFirstContext())
            {
                foreach (var user in db.Users)
                {
                    if (user.Name == username)
                    {
                        listBox.Items.Add(user.Name + (" (you)"));
                    }
                    else
                    {
                        listBox.Items.Add(user.Name);
                    }
                }
            }
        }
        public void seeAllCategories()
        {
            this.Info.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.textBoxOldPassword.Visible = false;
            this.confirmButton.Visible = false;
            this.listBox.Visible = true;
            this.text.Visible = true;
            this.text.Text = "Here are all the objects:";

            listBox.Items.Clear();
            using (var db = new CodeFirstContext())
            {
                string record;
                foreach (var cave in db.Caves)
                {
                    record = "Type: Cave, Name: " + cave.Name + ", Area: " + cave.Area;
                    listBox.Items.Add(record);
                }
                foreach (var forest in db.Forests)
                {
                    record = "Type: Forest, Name: " + forest.Name + ", Area: " + forest.Area;
                    listBox.Items.Add(record);
                }
                foreach (var tower in db.Towers)
                {
                    record = "Type: Tower, Name: " + tower.Name + ", Height: " + tower.Height + ", Age: " + tower.Age;
                    listBox.Items.Add(record);
                }
            }
        }

        public void openNewCategoryForm(int categoryType)
        {
            home.Hide();
            NewCategory newCategory = new NewCategory(this.username, categoryType);
            newCategory.ShowDialog();
            home.Close();
            
        }

        public void addNewCave()
        {
            this.openNewCategoryForm(1);
        }

        public void addNewForest()
        {
            this.openNewCategoryForm(2);
        }

        public void addNewTower()
        {
            this.openNewCategoryForm(3);
        }
    }
}
