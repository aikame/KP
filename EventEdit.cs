using KP.BD;
using KP.BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KP
{
    public partial class EventEdit : Form
    {
        readonly Database _db;
        readonly EventModel? _event;
        public enum windowmode
        {
            create = 0,
            update = 1,
            approve = 2
        }
        readonly windowmode _mode;
        readonly EventMenu _parent;
        public EventEdit(EventMenu parent, Database db)
        {
            _mode = windowmode.create;
            InitializeComponent();
            _db = db;
            _parent = parent;
        }

        public EventEdit(EventMenu parent, Database db, EventModel ev)
        {
            if (Auth.CurrentUser.AccountLevel < 1)
                _mode = windowmode.approve;
            else
                _mode = windowmode.update;
            InitializeComponent();
            _db = db;
            _event = ev;
            _parent = parent;
        }

        private void Save()
        {
            if (arttext.Text.Length > 0 && desctext.Text.Length > 0)
            {
                var Event = new EventModel();
                Event.Article = arttext.Text;
                Event.Description = desctext.Text;
                Event.DateTime = DateTimePicker.Value;
                _db.AddEvent(Event);
            }
            else
            {
                MessageBox.Show(
                    "Данное событие уже существует!", 
                    "Ошибка!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
                return;
            }
        }

        private void Edit()
        {
            if (arttext.Text.Length > 0 && desctext.Text.Length > 0)
            {
                var newEvent = new EventModel
                {
                    Article = arttext.Text,
                    Description = desctext.Text,
                    DateTime = DateTimePicker.Value
                };

                _db.UpdateEvent(_event, newEvent);
            }
        }

        private void SetCompetitor (bool IsCompetite)
        {
            _db.SetCompetition(Auth.CurrentUser, _event, IsCompetite);
        }

        private void EventEdit_Load(object sender, EventArgs e)
        {
            if (Auth.CurrentUser.AccountLevel < 1)
            {
                save.Text = "Принять участие";
                CancelB.Text = "Отказаться";
                arttext.Enabled = false;
                desctext.Enabled = false;
                DateTimePicker.Enabled = false;
            }
            if (_mode == windowmode.create)
                showCompB.Hide();
            if (_event != null)
            {
                arttext.Text = _event.Article;
                desctext.Text = _event.Description;
                DateTimePicker.Value = _event.DateTime;
            }
            switch(_mode)
            {
                case windowmode.create:
                    this.Text = "Создание события";
                    break;
                case windowmode.update:
                    this.Text = "Редактирование события";
                    break;
                case windowmode.approve:
                    this.Text = "Принятие участия в событии";
                    break;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case windowmode.create:
                    Save(); break;
                case windowmode.update:
                    Edit(); break;
                case windowmode.approve:
                    SetCompetitor(true); break;
            }
            _parent.Reload();
            Close();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case windowmode.create:
                    Close(); break;
                case windowmode.update:
                    Close(); break;
                case windowmode.approve:
                    SetCompetitor(false); break;
            }
            _parent.Reload();
            Close();
        }

        private void showCompB_Click(object sender, EventArgs e)
        {
            string Users = "";
            foreach (var c in _db.GetCompetitorsByEvent(_event))
            {
                Users += _db.GetUserById(c.UserId).Login + "\n";
            }
            MessageBox.Show(Users, "Участники", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
