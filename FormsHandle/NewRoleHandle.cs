using ArtifactManager.DataModels;
using ArtifactManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class NewRoleHandle : Form 
    {
        NewRole newRoleForm;
        string username;
        TextBox roleTextBox;
        CheckedListBox permissionsListBox;
        Button returnButton;
        Button addButton;

        public void getForm(NewRole newRoleForm_, string username_, TextBox roleTextBox_, CheckedListBox permissionsListBox_, Button returnButton_, 
            Button addButton_)
        {
            newRoleForm = newRoleForm_;
            username = username_;
            roleTextBox = roleTextBox_;
            permissionsListBox = permissionsListBox_;
            returnButton = returnButton_;
            addButton = addButton_;

            this.setPerms();
        }

        public void setPerms()
        {
            using (var db = new CodeFirstContext())
            {
                var names = typeof(Role).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

                for (int i = 2; i < names.Length; i++)
                {
                    permissionsListBox.Items.Add(names[i]);
                }
            }
        }

        public void checkIfRoleFilled()
        {
            if (roleTextBox.Text.Length > 0) addButton.Enabled = true;
            else addButton.Enabled = false;
        }

        public void returnToHomePanel()
        {
            newRoleForm.Hide();
            Home home = new Home(username);
            home.ShowDialog();
            newRoleForm.Close();
        }

        public int countSelectedPerms()
        {
            int count = 0;
            for(int i = 0; i < permissionsListBox.Items.Count; i++)
            {
                if (permissionsListBox.GetItemChecked(i)) count++;
            }
            return count;
        }

        public void addNewRole()
        {
            if(countSelectedPerms() == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to add it?", "Your Role has no permissions!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) return;
            }
            using(var db = new CodeFirstContext())
            {
                db.Roles.Add(new Role()
                {
                    Name = roleTextBox.Text,
                    AddCategory = permissionsListBox.GetItemChecked(0),
                    EditCategory = permissionsListBox.GetItemChecked(1),
                    DeleteCategory = permissionsListBox.GetItemChecked(2),
                    AddObject = permissionsListBox.GetItemChecked(3),
                    EditObject = permissionsListBox.GetItemChecked(4),
                    DeleteObject = permissionsListBox.GetItemChecked(5),
                    AddUser = permissionsListBox.GetItemChecked(6),
                    EditUser = permissionsListBox.GetItemChecked(7),
                    DeleteUser = permissionsListBox.GetItemChecked(8),
                    AddRole = permissionsListBox.GetItemChecked(9),
                    EditRole = permissionsListBox.GetItemChecked(10),
                    DeleteRole = permissionsListBox.GetItemChecked(11)                    
                });
                db.SaveChanges();
            }
            MessageBox.Show("Role added.");
            this.returnToHomePanel();
        }

    }
}
