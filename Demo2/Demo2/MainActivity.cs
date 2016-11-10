using Android.App;
using Android.Widget;
using Android.OS;
using Android.Locations;
using Android.Content;
using Android.Runtime;
using System;

namespace Demo2
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ILocationListener
    {
        LocationManager locationManager;
        TextView latitude;
        TextView longitude;
        string latitudeStr;
        string longitudeStr;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            latitude = FindViewById<TextView>(Resource.Id.latitude);
            longitude = FindViewById<TextView>(Resource.Id.longitude);
            latitudeStr = Resources.GetString(Resource.String.latitude);
            longitudeStr = Resources.GetString(Resource.String.longitude);
            locationManager = GetSystemService(Context.LocationService) as LocationManager;
        }

        protected override void OnResume()
        {
            base.OnResume();
            string Provider = LocationManager.GpsProvider;

            if (locationManager != null && locationManager.IsProviderEnabled(Provider))
            {
                locationManager.RequestLocationUpdates(Provider, 2000, 1, this);
            }
            else
            {
                Toast.MakeText(this, Resources.GetString(Resource.String.errorMsg), ToastLength.Long);
            }
        }


        protected override void OnPause()
        {
            base.OnPause();
            locationManager.RemoveUpdates(this);
        }

        public void OnLocationChanged(Location location)
        {
            latitude.Text = latitudeStr+ " " +location.Latitude;
            longitude.Text = longitudeStr+ " " + location.Longitude;
        }

        public void OnProviderDisabled(string provider)
        {
            
        }

        public void OnProviderEnabled(string provider)
        {
            
        }

        public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras)
        {
            
        }

    }
}

