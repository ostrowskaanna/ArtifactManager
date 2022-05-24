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
    public partial class ModifyUser : Form
    {
        User userToModify;
        string adminUsername;
        ModifyUserHandle modifyHandle = new ModifyUserHandle();

        public ModifyUser(User userToModify_, string adminUsername_)
        {
            InitializeComponent();
            userToModify = userToModify_;
            adminUsername = adminUsername_;
            modifyHandle.getModifyUserForm(this, this.returnButton, this.changeButton, this.adminUsername,
                this.userToModify, this.textBoxUsername, this.textBoxEmail, this.textBoxPassword, this.roleListBox);
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            modifyHandle.returnToHomePanel();
        }

        private void changeUserData(object sender, EventArgs e)
        {
            modifyHandle.changeUserData();
        }

        private void usernameChanged(object sender, EventArgs e)
        {
            modifyHandle.usernameChanged();
        }

        private void emailChanged(object sender, EventArgs e)
        {
            modifyHandle.emailChanged();
        }

        private void passwordChanged(object sender, EventArgs e)
        {
            modifyHandle.passwordChanged();
        }

        private void allowOnlyOneItemChecked(object sender, ItemCheckEventArgs e)
        {
            modifyHandle.allowOnlyOneItemChecked(e);
        }

        private void roleChanged(object sender, EventArgs e)
        {
            modifyHandle.roleChanged();
        }
    }
}
