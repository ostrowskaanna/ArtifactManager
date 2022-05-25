using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtifactManager.Forms;

namespace ArtifactManager.FormsHandle
{
    public class ModifyObjectHandle : Form
    {
        ModifyObject modifyobject;
        TextBox textBoxName;
        TextBox textBoxFirstAtt;
        TextBox textBoxSecondAtt;
        Button returnButton;
        Button changeButton;
        Label firstAtt;
        Label secondAtt;

        string username;
        string toModify;

        string name = null;
        string firstAttName = null;
        string secondAttName = null;
        string firstAttValue = null;
        string secondAttValue = null;
        string type = null;
        public void getForm(ModifyObject modifyobject_, TextBox textBoxName_, TextBox textBoxFirstAtt_, TextBox textBoxSecondAtt_, Button returnButton_,
            Button changeButton_, Label firstAtt_, Label secondAtt_, string username_, string toModify_)
        {
            modifyobject = modifyobject_;
            textBoxName = textBoxName_;
            textBoxFirstAtt = textBoxFirstAtt_;
            textBoxSecondAtt = textBoxSecondAtt_;
            returnButton = returnButton_;
            changeButton = changeButton_;
            firstAtt = firstAtt_;
            secondAtt = secondAtt_;
            username = username_;
            toModify = toModify_;
            this.show();
        }

        public void show()
        {
            string[] parts = toModify.Split(',');
            type = parts[0];
            name = parts[1];
            firstAttName = parts[2];
            secondAttName = parts[3];
            parts = type.Split(':');
            type = parts[1];
            parts = name.Split(':');
            name = parts[1];
            parts = firstAttName.Split(':');
            firstAttName = parts[0];
            firstAttValue = parts[1];
            parts = secondAttName.Split(':');
            secondAttName = parts[0];
            secondAttValue = parts[1];
            textBoxName.Text = name;
            textBoxFirstAtt.Text = firstAttValue;
            textBoxSecondAtt.Text = secondAttValue;
        }


        public void modifyobjectClick()
        {
            string table;
            if(type == "Wolf")
            {
                table = "Wolves";
            }
            else if(type == "Witch")
            {
                table = "Witches";
            }
            else if(type == "Magus")
            {
                table = type;
            }
            else
            {
                table = type + "s";
            }
            using(var db = new CodeFirstContext())
            {
                db.Database.ExecuteSqlCommand("UPDATE " + table + " SET Name = '" + textBoxName.Text + "', " + firstAttName + " = " +
                    int.Parse(textBoxFirstAtt.Text) + ", " + secondAttName + " = " + int.Parse(textBoxSecondAtt.Text) + " WHERE Name = '" + name + "';");
            }
            MessageBox.Show("Object changed.");
            this.returnToHomePanel();
        }

        public void nameChanged()
        {
            if (textBoxName.Text != name)
            {
                changeButton.Enabled = true;
            }
            else
            {
                changeButton.Enabled = false;
            }
        }

        public void firstAttChanged()
        {
            if (textBoxFirstAtt.Text != firstAttValue)
            {
                changeButton.Enabled = true;
            }
            else
            {
                changeButton.Enabled = false;
            }

        }

        public void secondAttChanged()
        {
            if (textBoxSecondAtt.Text != secondAttValue)
            {
                changeButton.Enabled = true;
            }
            else
            {
                changeButton.Enabled = false;
            }
        }

        public void returnToHomePanel()
        {
            modifyobject.Hide();
            Home home = new Home(username);
            home.ShowDialog();
            modifyobject.Close();
        }
    }
}
