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
        public NewRole(string username_)
        {
            InitializeComponent();
            username = username_;
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {

        }
    }
}
