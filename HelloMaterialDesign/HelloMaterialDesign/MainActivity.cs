using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloMaterialDesign
{
    [Activity(Label = "HelloMaterialDesign", 
              MainLauncher = true, 
              Icon = "@drawable/icon",
              Theme = "@style/MyCustomTheme")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

