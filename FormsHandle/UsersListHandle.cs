using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.FormsHandle
{
    public class UsersListHandle : Form
    {
        UsersList usersList;
        CheckedListBox list;
        string username;
        public void getUsersListForm(UsersList usersList_, CheckedListBox list_, string username_)
        {
            usersList = usersList_;
            list = list_;
            username = username_;
        }

        public void showAllUsers()
        {
            using (var db = new CodeFirstContext())
            {
                var allUsers = db.Users.Where(u => u.Name != username).ToList();
                foreach (var user in allUsers)
                {
                    list.Items.Add(user.Name);
                }
            }
        }


        public void allowOnlyOneItemChecked(ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < list.Items.Count; ++ix)
                if (ix != e.Index) list.SetItemChecked(ix, false);
        }

        public void deleteUser()
        {
            var userToDelete = list.SelectedItem;
            using(var db = new CodeFirstContext())
            {
                db.Users.Remove(db.Users.Where(u => u.Name == userToDelete.ToString()).FirstOrDefault());
                db.SaveChanges();
            }
            MessageBox.Show("User deleted.");
            for (int ix = 0; ix < list.Items.Count; ++ix)
                list.SetItemChecked(ix, false);
            list.Items.Clear();
            this.showAllUsers();
        }


        public void returnToHomePanel()
        {
            usersList.Hide();
            Home home = new Home(this.username);
            home.ShowDialog();
            usersList.Close();
        }

    }
}
