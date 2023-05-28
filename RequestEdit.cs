using KP.BD.Models;
using KP.BD;
using System;
using System.Windows.Forms;

namespace KP
{
    public partial class RequestEdit : Form
    {
        readonly Database _db;
        readonly bool _m;
        bool _m2;
        RequestModel? _requestModel;
        readonly Form _parent;
        public RequestEdit(Form parent, bool mode, Database db, RequestModel? rq)
        {
            _parent = parent;
            _m = mode;
            _db = db;
            _requestModel = rq;
            InitializeComponent();
        }

        private void RequestEdit_Load(object sender, EventArgs e)
        {
            if (_m)
            {
                saveB.Text = "Принять";
                cancelB.Text = "Отменить";
                this.Text = "Рассмотрение заявки";
            }
            else
            {
                saveB.Text = "Сохранить";
                cancelB.Text = "Отменить";
                this.Text = "Создание/редактирование заявки";
            }
            if (_requestModel != null)
            {
                _m2 = true;
                artbox.Text = _requestModel.Article;
                descbox.Text = _requestModel.Description;
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (artbox != null && descbox != null) 
            {
                var NewRequest = new RequestModel();
                NewRequest.Article = artbox.Text;
                NewRequest.Description = descbox.Text;
                NewRequest.UserId = Auth.CurrentUser.UserId;
                NewRequest.Status = null;
                _db.AddRequest(NewRequest);
                _parent.Update();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не хватает данных!!");
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
