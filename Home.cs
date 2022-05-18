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
    public partial class Home : Form
    {
        HomeHandle homeHandle = new HomeHandle();
        public string username;
        public Home(string username_)
        {
            InitializeComponent();
            username = username_;
            MessageBox.Show(username);
            homeHandle.getHomeForm(this, this.label1, this.label2, 
                this.textBoxOldPassword, this.textBoxNewPassword, this.confirmButton, this.username);
        }

        private void showProfileDetails(object sender, EventArgs e)
        {
            homeHandle.showProfileDetails();
        }

        private void changePassword(object sender, EventArgs e)
        {
            homeHandle.changePassword();
        }

        private void textBoxOldPasswordCheck(object sender, EventArgs e)
        {
            homeHandle.textBoxOldPasswordCheck();
        }

        private void textBoxNewPasswordCheck(object sender, EventArgs e)
        {
            homeHandle.textBoxNewPasswordCheck();
        }

        private void confirmButtonClick(object sender, EventArgs e)
        {
            homeHandle.confirmButtonClick();
        }
    }
}
