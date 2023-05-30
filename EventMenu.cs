using KP.BD;
using System;
using System.Dynamic;
using System.Windows.Forms;

namespace KP
{
    public partial class EventMenu : Form
    {
        readonly Database _db;
        public EventMenu(Database db)
        {
            _db = db;
            InitializeComponent();
        }

        

        private void EventMenu_Load(object sender, EventArgs e)
        {
            foreach (var ev in _db.GetEvents())
            {
                var TempItem = new ListViewItem();
                TempItem.SubItems.Add(ev.EventId.ToString());
                TempItem.Text = ev.Article.ToString();
            }
            if (Auth.CurrentUser.AccountLevel < 1)
                createB.Enabled = false;
        }

        private void createB_Click(object sender, EventArgs e)
        {
            var EventEditWindow = new EventEdit(this, _db);
            EventEditWindow.ShowDialog();
        }
    }
}
