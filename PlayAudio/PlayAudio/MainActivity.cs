using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace PlayAudio
{
    [Activity(Label = "PlayAudio", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        MediaPlayer _player;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            _player = MediaPlayer.Create(this, Resource.Raw.test);
            _player.Start();


        }
    }
}

