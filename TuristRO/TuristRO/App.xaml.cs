using System;
using System.IO;
using TuristRO.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();
            MainPage = new TuristRO.MainPage();

        }
        static DataBase database;
        public static DataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
