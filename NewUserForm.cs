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
    public partial class NewUserForm : Form
    {
        NewUserFormHandle handle = new NewUserFormHandle();
        public string userName;

        public NewUserForm(string username_)
        {
            InitializeComponent();
            this.userName = username_;
            handle.getNewUserForm(this, userName, this.listBoxRoles, this.textBoxUsername, 
                this.textBoxEmail, this.textBoxPassword, this.addButton);
            
        }

        private void textBoxUsernameCheck(object sender, EventArgs e)
        {
            handle.textBoxUsernameCheck();
        }

        private void textBoxEmailCheck(object sender, EventArgs e)
        {
            handle.texBoxEmailCheck();
        }

        private void textBoxPasswordCheck(object sender, EventArgs e)
        {
            handle.textBoxPasswordCheck();
        }

        private void allowOnlyOneItemCheck(object sender, ItemCheckEventArgs e)
        {
            handle.allowOnlyOneItemCheck(e);
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            handle.returnToHomePanel();
        }

        private void addNewUser(object sender, EventArgs e)
        {
            handle.addNewUser();
        }
    }
}
