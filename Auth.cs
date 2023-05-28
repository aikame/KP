using KP.BD;
using KP.BD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KP
{
    public partial class Auth : Form
    {
        Database Db { get; set; }
        public static UserModel CurrentUser { get; set; }
        public Auth(DataContext database)
        {
            Db = new Database(database);
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            CurrentUser = Db.getAuth(loginbox.Text, passwordbox.Text);
            if (CurrentUser != null ) {
                this.Hide();
                string name = CurrentUser.Login;
                var main = new MainMenu(name, Db);
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка!");
            }
        }
    }
}
