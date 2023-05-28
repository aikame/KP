using KP.BD;
using KP.BD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class EventMenu : Form
    {
        DataContext db;
        public EventMenu(DataContext datbas)
        {
            db = datbas;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            var evEd = new EventEdit(true, db);
        }
    }
}
