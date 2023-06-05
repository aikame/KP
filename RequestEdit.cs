using KP.BD.Models;
using KP.BD;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net;

namespace KP
{
    public partial class RequestEdit : Form
    {
        public enum windowmode
        {
            create = 0,
            update = 1,
            approve = 2
        }
        readonly windowmode _mode;
        readonly Database _db;
        readonly RequestModel? _requestModel;
        readonly RequestMenu _parent;
        public RequestEdit(RequestMenu parent, windowmode mode, Database db, RequestModel? rq)
        {
            _parent = parent;
            _mode = mode;
            _db = db;
            _requestModel = rq;
            InitializeComponent();
        }
        private void Save ()
        {
            if (artbox != null && descbox != null)
            {
                var NewRequest = new RequestModel();
                NewRequest.Article = artbox.Text;
                NewRequest.Description = descbox.Text;
                NewRequest.UserId = Auth.CurrentUser.UserId;
                NewRequest.Status = null;
                switch (_mode)
                {
                    case windowmode.create: 
                        _db.AddRequest(NewRequest); 
                        break;
                    case windowmode.update:
                        NewRequest.RequestId = _requestModel.RequestId;
                            _db.UpdateRequest(NewRequest); 
                        break;
                }
                _parent.ReloadForm();
                Close();
            }
            else
            {
                MessageBox.Show("Не хватает данных", "Ошибка!");
            }
        }

        private void RequestEdit_Load(object sender, EventArgs e)
        {
            if (_requestModel != null)
            {
                artbox.Text = _requestModel.Article;
                descbox.Text = _requestModel.Description;
                if (Auth.CurrentUser.Login == _db.GetRequestAuthor(_requestModel))
                    authorLabel.Text = "Вы";
                else
                    authorLabel.Text = _db.GetRequestAuthor(_requestModel);
            }
            else
            {
                authorLabel.Text = " ";
            }
            switch (_mode) 
            { 
                case windowmode.approve:
                    saveB.Text = "Принять";
                    cancelB.Text = "Отклонить";
                    this.Text = "Рассмотрение заявки";
                    artbox.Enabled = false;
                    descbox.Enabled = false;
                    break;
                case windowmode.update:
                    saveB.Text = "Сохранить";
                    cancelB.Text = "Отменить";
                    this.Text = "Редактирование заявки";
                    artbox.Enabled = true;
                    descbox.Enabled = true;
                    break;
                case windowmode.create:
                    saveB.Text = "Сохранить";
                    cancelB.Text = "Отменить";
                    this.Text = "Создание заявки";
                    artbox.Enabled = true;
                    descbox.Enabled = true;
                    break;
            }
            if (_mode == windowmode.approve)
            {

            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (_mode == windowmode.approve)
            {
                RequestModel newRequest = _requestModel;
                newRequest.Status = true;
                _db.UpdateRequest(newRequest);
                _parent.ReloadForm();
            }
            else
                Save();
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            if (_mode == windowmode.approve)
            {
                RequestModel newRequest = _requestModel;
                newRequest.Status = false;
                _db.UpdateRequest(newRequest);
                _parent.ReloadForm();
            }
            Close();
        }
    }
}
