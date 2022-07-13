using ArtifactManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class ModifyRoleHandle : Form
    {

        Label roleLabel;
        CheckedListBox permissions;
        Button returnButton;
        Button changeButton;
        Role roleToModify;
        string role;
        string username;

        public void getModifyRoleForm(Label roleLabel_, CheckedListBox permissions_, Button returnButton_, 
            Button changeButton_, Role roleToModify_, string role_, string username_)
        {
            roleLabel = roleLabel_;
            permissions = permissions_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            roleToModify = roleToModify_;
            role = role_;
            username = username_;
            this.set();
        }

        public void set()
        {
            roleLabel.Text = "Role: " + role;

            using(var db = new CodeFirstContext())
            {
                var names = typeof(Role).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

                for (int i = 2; i < names.Length; i++)
                {
                    permissions.Items.Add(names[i]);
                    
                    var perm = db.Roles.SqlQuery("SELECT " + names[i] + " FROM Roles WHERE Name = '" + role + "';").FirstOrDefault();
                    MessageBox.Show(perm.ToString());
                   
                   
                    //if (perm == 1) permissions.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }
    }
}
