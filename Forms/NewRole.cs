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

namespace ArtifactManager.Forms
{
    public partial class NewRole : Form
    {
        string username;
        NewRoleHandle newRoleHandle = new NewRoleHandle(); 
        public NewRole(string username_)
        {
            InitializeComponent();
            username = username_;
            newRoleHandle.getForm(this, username, this.roleTextBox, this.permissionsListBox, this.returnButton, this.addButton);
        }



        private void returnToHomePanel(object sender, EventArgs e)
        {
            newRoleHandle.returnToHomePanel();
        }

        private void checkIfRoleFilled(object sender, EventArgs e)
        {
            newRoleHandle.checkIfRoleFilled();
        }

        private void addNewRole(object sender, EventArgs e)
        {
            newRoleHandle.addNewRole();
        }
    }
}
