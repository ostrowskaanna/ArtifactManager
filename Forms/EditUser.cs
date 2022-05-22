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
    public partial class EditUser : Form
    {
        EditUserHandle editHandle = new EditUserHandle();
        public string username;

        public EditUser(string username_)
        {
            InitializeComponent();
            username = username_;
            editHandle.getUsersListForm(this, this.List, this.username);
            editHandle.showAllUsers();
        }


        private void allowOnlyOneItemChecked(object sender, ItemCheckEventArgs e)
        {
            editHandle.allowOnlyOneItemChecked(e);
            if(List.SelectedItem != null)
            {
                this.deleteButton.Enabled = true;
                this.modifyButton.Enabled = true;
            }
            else
            {
                this.deleteButton.Enabled = false;
                this.modifyButton.Enabled = false;
            }
        }

        private void deleteUser(object sender, EventArgs e)
        {
            editHandle.deleteUser();
            this.deleteButton.Enabled = false;
            this.modifyButton.Enabled = false;
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            editHandle.returnToHomePanel();
        }

        private void modifyUser(object sender, EventArgs e)
        {
            editHandle.modifyUser();
        }
    }
}
