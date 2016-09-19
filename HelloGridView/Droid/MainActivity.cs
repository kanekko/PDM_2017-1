using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloGridView.Droid
{
	[Activity(Label = "HelloGridView", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var gridview = FindViewById<GridView>(Resource.Id.gridview);
			gridview.Adapter = new ImageAdapter(this);

			gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
			{
				Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
			};

		}
	}
}


