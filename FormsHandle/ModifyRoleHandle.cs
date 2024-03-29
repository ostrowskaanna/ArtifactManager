﻿using ArtifactManager.DataModels;
using ArtifactManager.Forms;
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
        ModifyRole modifyRole;

        Label roleLabel;
        CheckedListBox permissions;
        Button returnButton;
        Button changeButton;
        Role roleToModify;
        string role;
        string username;

        string[] names;
        bool [] initialParams;

        public void getModifyRoleForm(ModifyRole modifyRole_, Label roleLabel_, CheckedListBox permissions_, Button returnButton_, 
            Button changeButton_, Role roleToModify_, string role_, string username_)
        {
            modifyRole = modifyRole_;
            roleLabel = roleLabel_;
            permissions = permissions_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            roleToModify = roleToModify_;
            role = role_;
            username = username_;
            initialParams = this.setInitialPerms();
        }

        public bool [] setInitialPerms()
        {
            roleLabel.Text = "Role: " + role;

            using (var db = new CodeFirstContext())
            {
                names = typeof(Role).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

                bool[] permsBeforeChange = new bool[names.Length - 2];

                for (int i = 2; i < names.Length; i++)
                {
                    permissions.Items.Add(names[i]);

                    bool perm = db.Database.SqlQuery<bool>("SELECT " + names[i] + " FROM Roles WHERE Name='" + role + "'").FirstOrDefault();
                    if (perm) permissions.SetItemCheckState(i - 2, CheckState.Checked);
                    permsBeforeChange[i - 2] = perm;
                }

                return permsBeforeChange;
            }
            
        }

        public void checkChanged()
        {
            changeButton.Enabled = false;
            for (int i = 0; i < permissions.Items.Count; i++)
            {
                if(permissions.GetItemChecked(i) != initialParams[i])
                {
                    changeButton.Enabled = true;
                    return;
                }
            }
        }

        public void changePerms()
        {
            using(var db = new CodeFirstContext())
            {
                for(int i = 0; i < permissions.Items.Count; i++)
                {
                    db.Database.ExecuteSqlCommand("UPDATE Roles SET " + names[i+2] + "='" + permissions.GetItemChecked(i).ToString() + 
                        "' WHERE Name='" + role + "';");
                }
                db.SaveChanges();
            }
            MessageBox.Show("Permissions have been changed.");
            this.returnToHome();

        }

        public void returnToHome()
        {
            modifyRole.Hide();
            Home home = new Home(username);
            home.ShowDialog();
            modifyRole.Close();
        }
    }
}
