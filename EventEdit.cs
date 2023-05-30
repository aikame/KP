using KP.BD;
using KP.BD.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KP
{
    public partial class EventEdit : Form
    {
        readonly Database _db;
        readonly EventModel? _event;
        readonly bool _mode;
        readonly EventMenu _parent;
        public EventEdit(EventMenu parent, Database db)
        {
            InitializeComponent();
            _db = db;
            _parent = parent;
        }

        public EventEdit(EventMenu parent, Database db, EventModel ev)
        {
            InitializeComponent();
            _db = db;
            _event = ev;
            _parent = parent;
        }

        private void EventEdit_Load(object sender, EventArgs e)
        {
            if (Auth.CurrentUser.AccountLevel < 1)
            {
                save.Text = "Принять участие";
                CancelB.Text = "Отказаться";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
