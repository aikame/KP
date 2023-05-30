using KP.BD;
using KP.BD.Models;
using System;
using System.Windows.Forms;

namespace KP
{
    public partial class UserEdit : Form
    {
        readonly Users _parent;
        readonly Database _db;
        readonly UserModel _user;
        readonly bool _flag;
        public UserEdit(Users parent, Database db, UserModel user)
        {
            _parent = parent;
            _flag = true;
            _user = user;
            _db = db;
            InitializeComponent();
        }

        public UserEdit(Users parent, Database db)
        {
            _parent = parent;
            _flag = false;
            _user = new UserModel();
            _db = db;
            InitializeComponent();
        }

        private void Save ()
        {
            if (LoginBox.Text != null && PasswordBox.Text != null)
            {
                UserModel _user = new UserModel();
                _user.Login = LoginBox.Text;
                _user.Password = PasswordBox.Text;
                switch (AccoutLevelBox.SelectedIndex)
                {
                    case 0: _user.AccountLevel = 0; break;
                    case 1: _user.AccountLevel = 1; break;
                    case 2: _user.AccountLevel = 2; break;
                    default: _user.AccountLevel = 0; break;
                }
                _db.UpdateUser(_user);
                _parent.Reload();
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Обнаружены пустые поля!", 
                    "Ошибка!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
        }
        private void Edit ()
        {
            if (LoginBox.Text != null && PasswordBox.Text != null)
            {
                _user.Login = LoginBox.Text;
                _user.Password = PasswordBox.Text;
                switch (AccoutLevelBox.SelectedIndex)
                {
                    case 0: _user.AccountLevel = 0; break;
                    case 1: _user.AccountLevel = 1; break;
                    case 2: _user.AccountLevel = 2; break;
                    default: _user.AccountLevel = 0; break;
                }
                _db.UpdateUser(_user);
                _parent.Reload();
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Обнаружены пустые поля!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (_flag)
                Edit();
            else
                Save();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {
                LoginBox.Text = _user.Login;
                PasswordBox.Text = _user.Password;
                switch (_user.AccountLevel)
                {
                    case 0: AccoutLevelBox.
                            SelectedIndex = 0; break;
                    case 1: AccoutLevelBox.
                            SelectedIndex = 1; break;
                    case 2: AccoutLevelBox.
                            SelectedIndex = 2; break;
                }
            }
        }
    }
}
