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
        User userToModify;
        public void getModifyUserForm(ModifyUser modifyuserForm_, Button returnButton_, Button changeButton_,
            string adminUsername_, User userToModify_, TextBox textBoxUsername_, TextBox textBoxEmail_, TextBox textBoxPassword_, 
            CheckedListBox roleListBox_)
        {
            modifyUserForm = modifyuserForm_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            adminUsername = adminUsername_;
            userToModify = userToModify_;
            textBoxUsername = textBoxUsername_;
            textBoxEmail = textBoxEmail_;
            textBoxPassword = textBoxPassword_;
            roleListBox = roleListBox_;
            this.showUser();

        }

        public void showUser()
        {
            textBoxUsername.Text = userToModify.Name;
            textBoxEmail.Text = userToModify.Email;
            //textBoxPassword.Text = userToModify.Password;
            using(var db = new CodeFirstContext())
            {
                int i = 0;
                string record;
                
                foreach(var role in db.Roles)
                {
                    roleListBox.Items.Add(role.Name);
                    if(role.Name == userToModify.Role)
                    {
                        roleListBox.SetItemCheckState(i, CheckState.Checked);
                    }
                    i++;
                }
                
            }
            
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
            if (textBoxUsername.Text == userToModify.Name || textBoxUsername.Text.Count() == 0)
            {
                changeButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = true;
            }
        }


        public void emailChanged()
        {
            if (textBoxEmail.Text == userToModify.Email || textBoxEmail.Text.Count() == 0)
            {
                changeButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = true;
            }
        }

        public void passwordChanged()
        {
            if (textBoxPassword.Text.Count() == 0)
            {
                changeButton.Enabled = false;
            }
            else
            {
                changeButton.Enabled = true;
            }
        }


        public void allowOnlyOneItemChecked(ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < roleListBox.Items.Count; ++ix)
                if (ix != e.Index) roleListBox.SetItemChecked(ix, false);

            if (roleListBox.SelectedIndex >= 0)
            {
                if (roleListBox.SelectedItem.ToString() != userToModify.Role)
                {
                    changeButton.Enabled = true;
                }
            }
        }

        public void changeUserData()
        {
            using(var db = new CodeFirstContext())
            {
                var user = db.Users.SingleOrDefault(u => u.Name == userToModify.Name);
                if (user != null)
                {
                    user.Name = textBoxUsername.Text;
                    user.Email = textBoxEmail.Text;
                    user.Password = textBoxPassword.Text;
                }
                db.SaveChanges();
            }
            MessageBox.Show("User data changed.");
            this.returnToHomePanel();
        }

    }
}
