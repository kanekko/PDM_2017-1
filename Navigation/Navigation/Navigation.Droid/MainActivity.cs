using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Navigation.Droid
{
	[Activity (Label = "Navigation.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            EditText myEditText = FindViewById<EditText>(Resource.Id.myEditText);


            button.Click += delegate {

                //StartActivity(typeof(Activity2));
                
                string value = myEditText.Text;

                var activity2 = new Intent(this, typeof(Activity2));
                activity2.PutExtra("MyData",value);
                StartActivity(activity2);
                
            };
		}
	}
}


