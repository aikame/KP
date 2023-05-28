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
                    ReqBox.Items.Add(r.Article);
                }
            }
            else 
                foreach(var r in _db.GetAllRequests())
                {
                    ReqBox.Items.Add(r.Article);
                }
        }

        private void createReq_Click(object sender, EventArgs e)
        {
            var window = new RequestEdit(this, false, _db, null);
            window.Show();
        }

        private void ReqBox_DoubleClick(object sender, EventArgs e)
        {
            var req = _db.GetRequestByArticle(ReqBox.Items[ReqBox.SelectedIndex].ToString());
            if (req != null) {
                var window = new RequestEdit(this, false, _db, req);
                window.Show();
            }
        }
    }
}
