using KP.BD;
using KP.BD.Models;
using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KP
{
    public partial class RequestMenu : Form
    {
        readonly Database _db;
        public RequestMenu(Database db)
        {
            _db = db;
            InitializeComponent();
        }

        public void ReloadForm ()
        {
            ReqBox.Clear();
            this.Loader();
        }

        private void Loader ()
        {
            if (Auth.CurrentUser.AccountLevel < 1)
            {
                foreach (var r in _db.GetRequestsByUser(Auth.CurrentUser))
                {
                    var TempItem = new ListViewItem();
                    TempItem.Text = r.Article.ToString();
                    TempItem.SubItems.Add(r.RequestId.ToString());
                    switch (r.Status)
                    {
                        case true: TempItem.BackColor = Color.Green; break;
                        case false: TempItem.BackColor = Color.Red; break;
                        default: TempItem.BackColor = Color.White; break;
                    }
                    ReqBox.Items.Add(TempItem);
                } 
            }
            else
            {
                foreach (var r in _db.GetAllRequests())
                {
                    var TempItem = new ListViewItem();
                    TempItem.Text = r.Article.ToString();
                    TempItem.SubItems.Add(r.RequestId.ToString());
                    switch (r.Status)
                    {
                        case true: TempItem.BackColor = Color.Green; break;
                        case false: TempItem.BackColor = Color.Red; break;
                        default: TempItem.BackColor = Color.White; break;
                    }
                    ReqBox.Items.Add(TempItem);
                }
                createB.Enabled = false;
                deleteB.Enabled = false;
            }
        }

        private void Edit(RequestModel req)
        {
            var window = new RequestEdit(this, RequestEdit.windowmode.update, _db, req);
            window.ShowDialog();
        }

        private void Create()
        {
            var window = new RequestEdit(this, RequestEdit.windowmode.create, _db, null);
            window.ShowDialog();
        }

        private void Acceptance (RequestModel req)
        {
            var window = new RequestEdit(this, RequestEdit.windowmode.approve, _db, req);
            window.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Loader();
        }

        private void createReq_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void ReqBox_DoubleClick(object sender, EventArgs e)
        {
            var req = _db.GetRequestById(Convert.ToInt16(ReqBox.SelectedItems[0].SubItems[1].Text));
            if (Auth.CurrentUser.AccountLevel < 1 && req != null)
                Edit(req);
            else
                Acceptance(req);
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            var req = _db.GetRequestById(Convert.ToInt16(ReqBox.SelectedItems[0].SubItems[1].Text));
            if (req != null)
                _db.RemoveRequest(req);
            ReloadForm();
        }
    }
}
