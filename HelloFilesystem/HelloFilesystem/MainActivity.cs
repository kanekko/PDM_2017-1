using Android.App;
using Android.Widget;
using Android.OS;

using System.IO;
using System;

namespace HelloFilesystem
{
    [Activity(Label = "HelloFilesystem", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView (Resource.Layout.Main);

            //internal storage
            string path = Application.Context.FilesDir.Path;
            var filePath = Path.Combine(path, "test.txt");
            System.IO.File.WriteAllText(filePath, "Hello World");
            // read from internal storage
            var reader = System.IO.File.ReadAllText(filePath);
            Console.WriteLine("reader:~>"+reader);

            //external storage (public)
            //string path2 = Android.OS.Environment.GetExternalStoragePublicDirectory.path;
            //external storage (private)
            //string path2 = Application.Context.GetExternalFilesDir;
        }
        



    }
    
}