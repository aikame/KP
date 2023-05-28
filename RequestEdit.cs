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
        RequestModel? _requestModel;
        readonly Form _parent;
        public RequestEdit(Form parent, bool mode, Database db, RequestModel? rq)
        {
            _parent = parent;
            _m = mode; // Создание - 0, Редактирование - 1
            _db = db;
            _requestModel = rq;
            InitializeComponent();
        }

        private void RequestEdit_Load(object sender, EventArgs e)
        {
            if (_requestModel != null)
            {
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
                if (!_m)
                {
                    _db.AddRequest(NewRequest);
                }
                else
                {
                    _db.UpdateRequest(_requestModel, NewRequest);
                }
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
