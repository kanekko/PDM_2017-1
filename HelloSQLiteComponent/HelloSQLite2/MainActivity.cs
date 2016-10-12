using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloSQLite2
{
    [Activity(Label = "HelloSQLite2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }



    private async Task<string> createDatabase(string path)
    {
        try
        {
            var connection = new SQLiteAsyncConnection(path);
            {
                await connection.CreateTableAsync<Person>();
                return "Database created";
            }
    catch (SQLiteException ex)
        {
            return ex.Message;
        }
    }



    private async Task<string> insertUpdateData(Person data, string path)
    {
        try
        {
            var db = new SQLiteAsyncConnection(path);
            if (await db.InsertAsync(data) != 0)
                await db.UpdateAsync(data);
            return "Single data file inserted or updated";
        }
        catch (SQLiteException ex)
        {
            return ex.Message;
        }
    }




    private async Task<int> findNumberRecords(string path)
    {
        try
        {
            var db = new SQLiteAsyncConnection(path);
            // this counts all records in the database, it can be slow depending on the size of the database
            var count = await db.ExecuteScalarAsync<int>("SELECT Count(*) FROM Person");

            // for a non-parameterless query
            // var count = db.ExecuteScalarAsync<int>("SELECT Count(*) FROM Person WHERE FirstName="Amy");

            return count;
        }
        catch (SQLiteException ex)
        {
            return -1;
        }
    }


}

