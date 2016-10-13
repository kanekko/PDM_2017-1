using Android.App;
using Android.Widget;
using Android.OS;

namespace PlayVideo
{
    [Activity(Label = "PlayVideo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var videoView = FindViewById<VideoView>(Resource.Id.SampleVideoView);

            var uri = Android.Net.Uri.Parse("http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4");


            videoView.SetVideoURI(uri);
            videoView.Start();
        }
    }
}

