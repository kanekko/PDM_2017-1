using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloTabbedLayout
{
	[Activity(Label = "HelloTabbedLayout", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Es necesario especificar un cambio en el tipo de navegación
			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
			//SetContentView(Resource.Layout.Main);

			// first tab
			var tab = ActionBar.NewTab();
			tab.SetText(Resources.GetString(Resource.String.tab1_text));
			tab.SetIcon(Resource.Drawable.tab1_icon);
			tab.TabSelected += (sender, args) =>
			{

				// Do something when tab is selected
			};

			ActionBar.AddTab(tab);


			//second tab
			tab = ActionBar.NewTab();
			tab.SetText(Resources.GetString(Resource.String.tab2_text));
			tab.SetIcon(Resource.Drawable.tab2_icon);
			tab.TabSelected += (sender, args) =>
			{
					// Do something when tab is selected
				SetContentView(Resource.Layout.Main);
			};

			ActionBar.AddTab(tab);
		}
	}
}

