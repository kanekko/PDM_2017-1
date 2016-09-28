using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Navigation.Droid
{
    [Activity(Label = "ActivityDiego")]
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity2);
            // Create your application here
            string text = Intent.GetStringExtra("MyData") ?? "Data not available";
            //////////////////////////////////////
            TextView myTextView = FindViewById<TextView>(Resource.Id.myTextView2);
            myTextView.Text = "Hola a todos";

            //////////////////////////////
            Switch s = FindViewById<Switch>(Resource.Id.mySwitch);

            s.CheckedChange += delegate (object sender, CompoundButton.CheckedChangeEventArgs e)
            {
                var toast = Toast.MakeText(this, "Your state is " + e.IsChecked, ToastLength.Short);
                toast.Show();
            };


            /////////////////////////////////////
            //Spinner spinner = FindViewById<Spinner>(Resource.Id.);
            
        }
    }
}