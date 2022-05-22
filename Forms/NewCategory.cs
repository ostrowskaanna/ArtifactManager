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
    public partial class NewCategory : Form
    {
        string username;
        public NewCategory(string username_, bool isTower_)
        {
            InitializeComponent();
            username = username_;
            if (isTower_)
            {
                area_ageLabel.Text = "Age: ";
                heightLabel.Visible = true;
                textBoxHeight.Visible = true;
            }

        }
    }
}
