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
        Button deleteButton;
        Button editButton;

        string username;

        bool oldPasswordFiled = false;
        bool newPasswordFilled = false;

        int whatIsShown;
        /* defines what is shown in listBox:
         * 1 - categories
         * 2 - objects
         * 3 - users
         * */

        public void getHomeForm(Home home_, Label label1_, Label label2_,
            TextBox textBoxOldPassword_, TextBox textBoxNewPasword_, Button confirmButton_, string username_,
            Label Info_, ListBox listBox_, Label text_, Button deleteButton_, Button editButton_)
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
            deleteButton = deleteButton_;
            editButton = editButton_;
        }

        public void showProfileDetails()
        {
            this.listBox.Visible = false;
            this.text.Visible = false;
            this.Info.Visible = true;
            this.textBoxOldPassword.Visible = false;
            this.textBoxNewPassword.Visible = false;
            this.deleteButton.Visible = false;
            this.editButton.Visible = false;
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
            this.deleteButton.Visible = false;
            this.editButton.Visible = false;
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
            this.deleteButton.Visible = true;
            this.editButton.Visible = true;
            this.deleteButton.Enabled = false;
            this.editButton.Enabled = false;

            whatIsShown = 3;

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
            this.text.Text = "Here are all the categories:";
            this.deleteButton.Visible = true;
            this.editButton.Visible = true;
            this.deleteButton.Enabled = false;
            this.editButton.Enabled = false;

            whatIsShown = 1;

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

        public void seeAllObjects()
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
            this.deleteButton.Visible = true;
            this.editButton.Visible = true;
            this.deleteButton.Enabled = false;
            this.editButton.Enabled = false;
            whatIsShown = 2;

            listBox.Items.Clear();


        }

        public void itemSelected()
        {
            if(listBox.SelectedIndex >= 0)
                deleteButton.Enabled = true;
                editButton.Enabled = true;
        }

        public void deleteSelectedItem()
        {
            if (whatIsShown == 1) this.deleteCategory();
            else if (whatIsShown == 2) this.deleteObject();
            else if(whatIsShown == 3) this.deleteUser();
        }

        public void deleteCategory()
        {
            //usuwanie kategorii
        }

        public void deleteObject()
        {
            //usuwanie obiektu 
            
        }

        public void deleteUser()
        {
            var userToDelete = listBox.SelectedItem;
            using (var db = new CodeFirstContext())
            {
                db.Users.Remove(db.Users.Where(u => u.Name == userToDelete.ToString()).FirstOrDefault());
                db.SaveChanges();
            }
            MessageBox.Show("User deleted.");
            this.seeAllUsers();
        }

        public void editSelectedItem()
        {
            if(whatIsShown == 1) this.editCategory();
            else if (whatIsShown == 2) this.editObject();
            else if(whatIsShown == 3) this.editUser();
        }

        public void editCategory()
        {
            //edytowanie kategorii
        }

        public void editObject()
        {
            //edytowanie obiektu 
        }

        public void editUser()
        {
            User userToModify;
            string user = listBox.SelectedItem.ToString();
            using (var db = new CodeFirstContext())
            {
                userToModify = db.Users.FirstOrDefault(u => u.Name == user);
            }

            this.Hide();
            ModifyUser modifyUserForm = new ModifyUser(userToModify, this.username);
            modifyUserForm.ShowDialog();
            this.Close();
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

        public void addNewCategoryObject(int objectType)
        {
            /* objectType defines what character is being created
             * 1 - Dragon
             * 2 - Bat
             * 3 - Spider
             * 4 - Ent
             * 5 - Wolf
             * 6 - Giant 
             * 7 - Knight
             * 8 - Magus 
             * 9 - Witch
             * */
            home.Hide();
            NewCategoryObject newObject = new NewCategoryObject(this.username, objectType);
            newObject.ShowDialog();
            home.Close();
        }
    }
}
