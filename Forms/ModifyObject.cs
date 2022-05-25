using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using ArtifactManager.FormsHandle;

namespace ArtifactManager.Forms
{
    public partial class ModifyObject : Form
    {
        string username;
        string toModify;
        ModifyObjectHandle modifyObjectHandle;
        public ModifyObject(string username_, string toModify_)
        {
            InitializeComponent();
            this.username = username_;
            this.toModify = toModify_;
            modifyObjectHandle = new ModifyObjectHandle();
            modifyObjectHandle.getForm(this, this.textBoxName, this.textBoxFirstAtt, this.textBoxSecondAtt, this.returnButton, this.changeButton, 
                this.firstAtt, this.secondAtt, this.username, this.toModify);
        }

        private void returnToHomePanel(object sender, EventArgs e)
        {
            modifyObjectHandle.returnToHomePanel();
        }

        private void modifyObjectClick(object sender, EventArgs e)
        {
            modifyObjectHandle.modifyobjectClick();
        }

        private void nameChanged(object sender, EventArgs e)
        {
            modifyObjectHandle.nameChanged();
        }

        private void firstAttChanged(object sender, EventArgs e)
        {
            modifyObjectHandle.firstAttChanged();
        }

        private void secondAttChanged(object sender, EventArgs e)
        {
            modifyObjectHandle.secondAttChanged();
        }
    }
}
