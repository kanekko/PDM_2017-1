using Android.App;
using Android.Widget;
using Android.OS;

namespace AppClase1
{
    [Activity(Label = "AppClase1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText et;
        TextView tv;
        Button bt;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            et = FindViewById<EditText>(Resource.Id.edittext);
            tv = FindViewById<TextView>(Resource.Id.textview);
            bt = FindViewById<Button>(Resource.Id.button);

            et.TextChanged += Et_TextChanged;
            bt.Click += Bt_Click;
        }

        private void Bt_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(Autocompletar));
        }

        private void Et_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            tv.Text = e.Text.ToString();
        }
    }
}

