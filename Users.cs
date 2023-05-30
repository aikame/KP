using KP.BD;
using KP.BD.Models;
using System;
using System.Windows.Forms;

namespace KP
{
    public partial class Users : Form
    {
        readonly Database _db;
        public Users(Database db)
        {
            _db = db;
            InitializeComponent();
        }

        public void Reload()
        {
            usersBox.Clear();
            foreach (var u in _db.GetUsers())
            {
                var TempItem = new ListViewItem();
                TempItem.SubItems.Add(u.UserId.ToString());
                TempItem.Text = u.Login;
                usersBox.Items.Add(TempItem);
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            var createWindow = new UserEdit(this, _db);
            createWindow.ShowDialog();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            foreach (var u in _db.GetUsers())
            {
                var TempItem = new ListViewItem();
                TempItem.SubItems.Add(u.UserId.ToString());
                TempItem.Text = u.Login;
                usersBox.Items.Add(TempItem);
            }
        }

        private void usersBox_DoubleClick(object sender, EventArgs e)
        {
            var user = _db.GetUserById(Convert.ToInt16(usersBox.SelectedItems[0].SubItems[1].Text));
            var userEditWindow = new UserEdit(this, _db, user);
            userEditWindow.ShowDialog();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            var user = _db.GetUserById(Convert.ToInt16(usersBox.SelectedItems[0].SubItems[1].Text));
            if (user == null)
            {
                return;
            }
            var result = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _db.RemoveUser(user);
                Reload();
            }
        }
    }
}
