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
    public partial class ModifyCategory : Form
    {
        string username;
        string toModify;
        ModifyCategoryHandle modifyCategoryHandle;

        public ModifyCategory(string username_, string toModify_)
        {
            InitializeComponent();
            this.username = username_;
            this.toModify = toModify_;
            modifyCategoryHandle = new ModifyCategoryHandle();
            modifyCategoryHandle.getModifyCategoryForm(this, this.textBoxName, this.textBoxArea, this.textBoxHeight, 
                this.height, this.returnButton, this.changeButton, 
                this.username, this.toModify);
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            modifyCategoryHandle.returnToHomePanel();
        }

        private void nameChanged(object sender, EventArgs e)
        {
            modifyCategoryHandle.nameChanged();
        }

        private void areaChanged(object sender, EventArgs e)
        {
            modifyCategoryHandle.areaChanged();
        }

        private void modifyCategory(object sender, EventArgs e)
        {
            modifyCategoryHandle.modify();
        }
    }
}
