using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.FormsHandle;

namespace ArtifactManager
{
    public partial class UsersList : Form
    {
        UsersListHandle usersListHandle = new UsersListHandle();
        public string username;

        public UsersList(string username_)
        {
            InitializeComponent();
            username = username_;
            usersListHandle.getUsersListForm(this, this.List, this.username);
            usersListHandle.showAllUsers();
        }


        private void allowOnlyOneItemChecked(object sender, ItemCheckEventArgs e)
        {
            usersListHandle.allowOnlyOneItemChecked(e);
            if(List.SelectedItem != null)
            {
                this.deleteButton.Enabled = true;
                this.modifyButton.Enabled = true;
            }
        }

        private void deleteUser(object sender, EventArgs e)
        {
            usersListHandle.deleteUser();
            this.deleteButton.Enabled = false;
            this.modifyButton.Enabled = false;
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            usersListHandle.returnToHomePanel();
        }

        private void checkIfItemChosen(object sender, EventArgs e)
        {
            if(List.SelectedItem == null)
            {
                this.deleteButton.Enabled = false;
                this.modifyButton.Enabled = false;
            }
            else
            {
                this.deleteButton.Enabled = true;
                this.modifyButton.Enabled = true;
            }
        }
    }
}
