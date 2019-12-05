using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.IO;



using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Environment = System.Environment;

namespace DataBaseCrud.Droid
{
    public class DataBaseConnection_Android : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            var path = System.IO.Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}