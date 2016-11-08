using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace UIDemo1
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText editText;
        TextView textView;
        Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            editText = FindViewById<EditText>(Resource.Id.editText);
            textView = FindViewById<TextView>(Resource.Id.textView);
            button = FindViewById<Button>(Resource.Id.autoButton);
            editText.TextChanged += EditText_TextChanged;
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(Autocomplete));
            StartActivity(intent);
        }

        private void EditText_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            textView.Text = e.Text.ToString();
        }
    }
}

