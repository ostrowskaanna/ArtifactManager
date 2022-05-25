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
        string objectType;
        NewCategoryObjectHandle objectHandle = new NewCategoryObjectHandle();
        Dictionary<string, string> objAtt;
        List<string> categories;
        List<int> categoryIds;
        public NewCategoryObject(string username_, string objectType_, Dictionary<string, string> objAtt_, List<string> categories_,
             List<int> categoryIds_)
        {
            InitializeComponent();
            this.username = username_;
            this.objectType = objectType_;
            this.objAtt = objAtt_;
            this.categories = categories_;
            this.categoryIds = categoryIds_;
            this.setComponents();
            objectHandle.getNewCategoryObjectForm(this, this.textBoxName, this.comboBoxCategoryType,
                this.textBoxFirstAttribute, this.textBoxSecondAttribute, this.addButton, this.username, this.objectType, 
                this.objAtt, this.categories, this.categoryIds);
            
        }

        public void setComponents()
        {
            this.type.Text = objectType;
            string info = objAtt[objectType];
            string[] attributes = info.Split(',');
            this.categoryType.Text = attributes[0];
            this.firstAttribute.Text = attributes[1];
            this.secondAttribute.Text = attributes[2];
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
