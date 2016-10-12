using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace HelloProperties
{
    [Activity(Label = "HelloProperties", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            
            ISharedPreferences prefs = Application.Context.GetSharedPreferences("PREF_NAME", FileCreationMode.Private);
            ISharedPreferencesEditor editor = prefs.Edit();
            //write shared preferences
            editor.PutInt("_key1", 10);
            editor.PutString("key2", "Xamarin Example");
            editor.Apply();


            //retrive sharede preferences
            var value1 = prefs.GetInt("key1", 0);
            var value2 = prefs.GetString("key2", null);

            Console.WriteLine("value1:~>" + value1);
            Console.WriteLine("value2:~>" + value2);
        }
    }
}

