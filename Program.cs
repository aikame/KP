using KP.BD;
using KP.BD.Models;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace KP
{
    internal static class Program
    {
        static string ConnectionString { get; set; }
        static DataContext Db { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeDataContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth(Db));
        }

        private static void InitializeDataContext()
        {
            // Читаем конфиг
            ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            // Создаем объект БД
            Db = new DataContext(ConnectionString);

            // Создаем БД, если её ещё нет
            if (!Db.Database.Exists())
            {
                Db.Database.Initialize(true);
                // Добавим тестовые профили
                UserModel director = new UserModel
                {
                    Login = "director",
                    Password = "director",
                    AccountLevel = 2
                };
                UserModel manager = new UserModel
                {
                    Login = "manager",
                    Password = "manager",
                    AccountLevel = 1
                };
                UserModel musician1 = new UserModel
                {
                    Login = "musician1",
                    Password = "1",
                    AccountLevel = 0
                };
                UserModel musician2 = new UserModel
                {
                    Login = "musician2",
                    Password = "1",
                    AccountLevel = 0
                };
                UserModel musician3 = new UserModel
                {
                    Login = "musician3",
                    Password = "1",
                    AccountLevel = 0
                };
                Db.User.Add(director);
                Db.User.Add(manager);
                Db.User.Add(musician1);
                Db.User.Add(musician2);
                Db.User.Add(musician3);
                Db.SaveChanges();
            }
        }
    }
}
