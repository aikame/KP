using KP.BD;
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
            Console.WriteLine("Инициализация базы данных...");
            // Читаем конфиг
            ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            // Создаем объект БД
            Db = new DataContext(ConnectionString);

            // Создаем БД, если её ещё нет
            if (!Db.Database.Exists())
            {
                Console.WriteLine("БД отсутствует, создается пустая БД...");
                Db.Database.Initialize(true);
            }
            Console.WriteLine("Готово!");
        }
    }
}
