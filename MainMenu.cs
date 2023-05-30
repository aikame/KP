using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KP.BD.Models;
using KP;
using KP.BD;

namespace KP
{
    public partial class MainMenu : Form
    {
        readonly string _name;
        readonly Database _db;
        public MainMenu(string name, Database db)
        {
            _name = name;
            _db = db;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Auth.CurrentUser.AccountLevel < 2)
                usersB.Hide();
            label1.Text = $"Hello, {_name}!";
        }

        private void requestB_Click(object sender, EventArgs e)
        {
            var window = new RequestMenu(_db);
            window.ShowDialog();
        }

        private void usersB_Click(object sender, EventArgs e)
        {
            var window = new Users(_db);
            window.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var window = new EventMenu(_db);
            window.ShowDialog();
        }
    }
}
