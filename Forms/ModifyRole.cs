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
        ModifyRoleHandle modifyRoleHandle = new ModifyRoleHandle();

        public ModifyRole(Role roleToModify_)
        {
            InitializeComponent();
            roleToModify = roleToModify_;
            modifyRoleHandle.getModifyRoleForm();
        }
    }
}
