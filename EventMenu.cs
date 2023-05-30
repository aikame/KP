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

        public void Reload()
        {
            EventView.Clear();
            foreach (var ev in _db.GetEvents())
            {
                var TempItem = new ListViewItem();
                TempItem.SubItems.Add(ev.EventId.ToString());
                TempItem.Text = ev.Article.ToString();
                EventView.Items.Add(TempItem);
            }
            if (Auth.CurrentUser.AccountLevel < 1)
            {
                createB.Enabled = false;
                deleteB.Enabled = false;
            }
        }

        private void EventMenu_Load(object sender, EventArgs e)
        {
            foreach (var ev in _db.GetEvents())
            {
                var TempItem = new ListViewItem();
                TempItem.SubItems.Add(ev.EventId.ToString());
                TempItem.Text = ev.Article.ToString();
                EventView.Items.Add(TempItem);
            }
            if (Auth.CurrentUser.AccountLevel < 1)
                createB.Enabled = false;
        }

        private void createB_Click(object sender, EventArgs e)
        {
            var EventEditWindow = new EventEdit(this, _db);
            EventEditWindow.ShowDialog();
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            var Id = _db.GetEventById(Convert.ToInt16(EventView.SelectedItems[0].SubItems[1].Text));
            if (Id != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить событие?", 
                    "Подтвердите действие", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _db.RemoveEvent(Id);
                    Reload();
                }

            }
        }
    }
}
