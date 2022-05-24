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

namespace ArtifactManager.Forms
{
    public partial class NewCategoryObject : Form
    {
        string username;
        int objectType;
        NewCategoryObjectHandle objectHandle = new NewCategoryObjectHandle();
        public NewCategoryObject(string username_, int objectType_)
        {
            InitializeComponent();
            this.username = username_;
            this.objectType = objectType_;
            this.setComponents();
            objectHandle.getNewCategoryObjectForm(this, this.textBoxName, this.comboBoxCategoryType,
                this.textBoxFirstAttribute, this.textBoxSecondAttribute, this.addButton, this.username, this.objectType);
        }

        public void setComponents()
        {
            /* objectType defines what character is being created
             * 1 - Dragon
             * 2 - Bat
             * 3 - Spider
             * 4 - Ent
             * 5 - Wolf
             * 6 - Giant 
             * 7 - Knight
             * 8 - Magus 
             * 9 - Witch
             * */
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
            else if (objectType == 3)
            {
                this.type.Text = "Spider";
                this.categoryType.Text = "Cave";
                this.firstAttribute.Text = "Speed [int]:";
                this.secondAttribute.Text = "Sight [int]:";
            }
            else if (objectType == 4)
            {
                this.type.Text = "Ent";
                this.categoryType.Text = "Forest";
                this.firstAttribute.Text = "Power [int]:";
                this.secondAttribute.Text = "Courage [int]:";
            }
            else if (objectType == 5)
            {
                this.type.Text = "Wolf";
                this.categoryType.Text = "Forest";
                this.firstAttribute.Text = "Power [int]:";
                this.secondAttribute.Text = "Speed [int]:";
            }
            else if (objectType == 6)
            {
                this.type.Text = "Giant";
                this.categoryType.Text = "Forest";
                this.firstAttribute.Text = "Height [int]:";
                this.secondAttribute.Text = "Sight [int]:";
            }
            else if (objectType == 7)
            {
                this.type.Text = "Knight";
                this.categoryType.Text = "Tower";
                this.firstAttribute.Text = "Power [int]:";
                this.secondAttribute.Text = "Courage [int]:";
            }
            else if (objectType == 8)
            {
                this.type.Text = "Magus";
                this.categoryType.Text = "Tower";
                this.firstAttribute.Text = "Power [int]:";
                this.secondAttribute.Text = "Smart [int]:";
            }
            else if (objectType == 9)
            {
                this.type.Text = "Witch";
                this.categoryType.Text = "Tower";
                this.firstAttribute.Text = "Power [int]:";
                this.secondAttribute.Text = "Smart [int]:";
            }
        }


        private void addNewObject(object sender, EventArgs e)
        {
            this.objectHandle.addNewObject();
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            this.objectHandle.returnToHomePanel();
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nameChanged(object sender, EventArgs e)
        {
            objectHandle.nameChanged();
        }

        private void typeChanged(object sender, EventArgs e)
        {
            objectHandle.typeChanged();
        }

        private void firstAttChanged(object sender, EventArgs e)
        {
            objectHandle.firstAttChanged();
        }

        private void secondAttChanged(object sender, EventArgs e)
        {
            objectHandle.secondAttChanged();
        }
    }
}
