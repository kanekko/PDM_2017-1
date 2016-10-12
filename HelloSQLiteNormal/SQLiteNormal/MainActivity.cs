using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;
using Android.Database.Sqlite;
using Android.Content;

namespace SQLiteNormal
{
    [Activity(Label = "SQLiteNormal", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);


            //Creating DataBase
            string path = Application.Context.FilesDir.Path;
            var pathToDatabase = Path.Combine(path, "db_messages.db");
            SQLiteDatabase sqlDB = SQLiteDatabase.OpenOrCreateDatabase(pathToDatabase, null);

            // create and open connection
            string createTbl = "CREATE Table Messages (_ID INTEGER PRIMARY KEY, message TEXT) ";
            sqlDB.ExecSQL(createTbl);
            ContentValues values = new ContentValues();
            values.Put("_ID", 1);
            values.Put("message", "test message");
            sqlDB.Insert("Messages", null, values);

            //working with data base
            Android.Database.ICursor cursor = sqlDB.RawQuery("SELECT * FROM Messages", null);
            string p = "";
            StartManagingCursor(cursor);
            if (cursor.MoveToFirst())
            {
                do
                {
                    p += cursor.GetInt(cursor.GetColumnIndex("_ID")) + cursor.GetString(cursor.GetColumnIndex("message"));
                } while (cursor.MoveToNext());
            }
            StopManagingCursor(cursor);
            cursor.Close();
        }
        }
}

