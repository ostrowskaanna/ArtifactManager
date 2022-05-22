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
    public partial class NewCategory : Form
    {
        string username;
        int categoryType;
        NewCategoryHandle newCategoryHandle = new NewCategoryHandle();
        public NewCategory(string username_, int categoryType_)
        {
            InitializeComponent();
            username = username_;
            categoryType = categoryType_;

            if (categoryType == 1) this.type.Text = "Cave";
            else if (categoryType == 2) this.type.Text = "Forest";
            else
            {
                this.type.Text = "Tower";
                area_ageLabel.Text = "Age: ";
                heightLabel.Visible = true;
                textBoxHeight.Visible = true;
            }
            newCategoryHandle.getNewCategoryForm(this, this.categoryType, this.textBoxName, this.textBoxAreaAge,
                this.textBoxHeight, this.addButton, this.username);
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            newCategoryHandle.returnToHomePanel();
        }

        private void nameChanged(object sender, EventArgs e)
        {
            newCategoryHandle.nameChanged();
        }

        private void areaAgeChanged(object sender, EventArgs e)
        {
            newCategoryHandle.areaAgeChanged();
        }

        private void heightChanged(object sender, EventArgs e)
        {
            newCategoryHandle.heightChanged();
        }

        private void addNewCategory(object sender, EventArgs e)
        {
            newCategoryHandle.addNewCategory();
        }
    }
}
