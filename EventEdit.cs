using KP.BD;
using KP.BD.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KP
{
    public partial class EventEdit : Form
    {
        readonly DataContext db;
        readonly bool m;
        EventModel em;
        public EventEdit(bool mode, DataContext database)
        {
            db = database;
            m = mode;
            em = new EventModel();
            // Режим 0 - создание
            // Режим 1 - редактирование
            InitializeComponent();
        }

        private void EventEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
