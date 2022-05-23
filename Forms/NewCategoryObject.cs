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
    public partial class NewCategoryObject : Form
    {
        string username;
        int objectType;
        public NewCategoryObject(string username_, int objectType_)
        {
            InitializeComponent();
            this.username = username_;
            this.objectType = objectType_;
            this.setComponents();
        }

        public void setComponents()
        {
            if (objectType == 1)
            {
                this.type.Text = "Dragon";
                this.categoryType.Text = "Cave";
                this.firstAttribute.Text = "Power [int]:";
                this.secondAttribute.Text = "Courage [int]:";
            }
            else if (objectType == 2)
            {
                this.type.Text = "Bat";
                this.categoryType.Text = "Cave";
                this.firstAttribute.Text = "Speed [int]:";
                this.secondAttribute.Text = "Size [int]:";
            }
        }


        private void addNewObject(object sender, EventArgs e)
        {

        }
    }
}
