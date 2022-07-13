using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.DataModels;
using ArtifactManager.FormsHandle;

namespace ArtifactManager.Forms
{
    public partial class ModifyRole : Form
    {

        Role roleToModify;
        string role;
        string username;
        ModifyRoleHandle modifyRoleHandle = new ModifyRoleHandle();

        public ModifyRole(Role roleToModify_, string role_, string username_)
        {
            InitializeComponent();
            roleToModify = roleToModify_;
            role = role_;
            username = username_;
            modifyRoleHandle.getModifyRoleForm(this.roleLabel, this.permisionsListBox, this.returnButton, 
                this.changeButton, this.roleToModify, this.role, this.username);
        }
    }
}
