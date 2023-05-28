using KP.BD.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace KP.BD
{
    public class Database
    {
        private readonly DataContext _context;

        public Database(DataContext context)
        {
            _context = context;
        }

        public void AddUser (UserModel user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public void RemoveUser(UserModel user)
        {
            _context.User.Remove(user);
            _context.SaveChanges();
        }

        public void UpdateUser (UserModel prevUser, UserModel newUser)
        {
            _context.User.AddOrUpdate(newUser);
            _context.SaveChanges();
            return;
        }

        public void AddRequest (RequestModel request)
        {
            if (_context.Request.AsEnumerable().Where(r => r.Article == request.Article && r.Description == request.Description).Any()) 
                { MessageBox.Show("Данная заявка уже существует!!"); return; }
            _context.Request.Add(request);
            _context.SaveChanges();
            return;
        }

        public void UpdateRequest (RequestModel oldRequest, RequestModel newRequest) 
        {
            if (oldRequest == newRequest)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show("Изменений нет\nВы уверены, что хотите продолжить?",
                                            "Внимание!", 
                                            buttons);
                if (result == DialogResult.No) { return; }
            }
            else 
            {
                _context.Request.Remove(oldRequest);
                _context.Request.Add(newRequest);
            }
            _context.SaveChanges();
        }

        // Получение данных
        public UserModel getAuth(string login, string password)
        {
            return _context.User.AsEnumerable().Where(u => u.Login == login && u.Password == password).FirstOrDefault();
        }

        public List<UserModel> GetUsers()
        {
            return _context.User.AsEnumerable().ToList();
        }

        public List<UserModel> GetUserById (int id)
        {
            return _context.User.AsEnumerable().Where(u => u.UserId == id).ToList();
        }

        public List<RequestModel> GetRequestsByUser (UserModel user) 
        {
            return _context.Request.AsEnumerable().Where(r => r.UserId == user.UserId).ToList();
        }

        public RequestModel GetRequestById (int Id)
        {
            return _context.Request.AsEnumerable().Where(r => r.RequestId == Id).FirstOrDefault();
        }

        public List<RequestModel> GetAllRequests()
        {
            return _context.Request.AsEnumerable().ToList();
        }

        public string GetRequestAuthor (RequestModel req)
        {
            return _context.User.AsEnumerable().Where(u => u.UserId == req.UserId).First().Login;
        }

        public List<EventModel> GetEvents ()
        {
            return _context.Event.AsEnumerable().ToList();
        }

        public List<CompetitorModel> GetCompetitorsByEvent (EventModel evt) 
        {
            return _context.CompetitorModel.AsEnumerable().Where(c => c.EventId == evt.EventId).ToList();
        }
    }
}
