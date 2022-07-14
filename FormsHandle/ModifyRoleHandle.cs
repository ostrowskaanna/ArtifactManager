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

        bool [] changedParams;

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
            changedParams = this.setInitialPerms();
        }

        public bool [] setInitialPerms()
        {
            roleLabel.Text = "Role: " + role;

            using (var db = new CodeFirstContext())
            {
                var names = typeof(Role).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

                

                for (int i = 2; i < names.Length; i++)
                {
                    permissions.Items.Add(names[i]);

                    bool perm = db.Database.SqlQuery<bool>("SELECT " + names[i] + " FROM Roles WHERE Name='" + role + "'").FirstOrDefault();
                    if (perm) permissions.SetItemCheckState(i-2, CheckState.Checked);

                }

                bool [] paramsChanged = new bool[permissions.Items.Count];
                for (int i = 0; i < paramsChanged.Length; i++)
                {
                    paramsChanged[i] = false;
                }
                return paramsChanged;
            }
            
        }

        public void checkChanged(int changedIndex)
        {
            MessageBox.Show(changedIndex.ToString());
            //changedParams[changedIndex] = !changedParams[changedIndex];
            //if (checkIfAnyParamsIsChanged()) changeButton.Enabled = true;
            //else changeButton.Enabled = false;
        }


        public bool checkIfAnyParamsIsChanged()
        {
            for(int i = 0; i < changedParams.Length; i++)
            {
                if (changedParams[i]) return true; 
            }
            return false;
        }

        public void changePerms()
        {

        }

        public void returnToHome()
        {
            this.Hide();
            Home home = new Home(username);
            home.ShowDialog();
            this.Close();
        }
    }
}
