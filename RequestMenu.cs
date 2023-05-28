using KP.BD;
using KP.BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Auth.CurrentUser.AccountLevel < 1)
            {
                foreach (var r in _db.GetRequestsByUser(Auth.CurrentUser))
                {
                    var TempItem = new ListViewItem();
                    TempItem.SubItems.Add(r.RequestId.ToString());
                    TempItem.Text = r.Article.ToString();
                    ReqBox.Items.Add(TempItem);
                }
                createReq.Enabled = true;
            }
            else
            {
                foreach (var r in _db.GetAllRequests())
                {
                    ReqBox.Items.Add(r.Article);
                }
                createReq.Enabled = false;
            }
        }

        private void createReq_Click(object sender, EventArgs e)
        {
            var window = new RequestEdit(this, false, _db, null);
            window.Show();
        }

        private void ReqBox_DoubleClick(object sender, EventArgs e)
        {
            var req = _db.GetRequestById(Convert.ToInt16(ReqBox.SelectedItems[0].SubItems[1].Text));

            if (req != null)
            {
                if (Auth.CurrentUser.AccountLevel < 1) 
                { 
                    var window = new RequestEdit(this, false, _db, req);
                    window.Show();
                }
                else
                {
                    //
                }
            }
        }
    }
}
