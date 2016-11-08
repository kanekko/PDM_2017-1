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

namespace UIDemo1
{
    [Activity(Label = "Autocomplete")]
    public class Autocomplete : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            var autoCompleteOptions = new String[] { "Hello", "Hey", "Heja", "Hi", "Hola", "Bonjour", "Gday", "Goodbye", "Sayonara", "Farewell", "Adios" };
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Autocomplete);
            ArrayAdapter autoCompleteAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, autoCompleteOptions);
            var autocompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.AutoCompleteInput);
            autocompleteTextView.Adapter = autoCompleteAdapter;
        }
    }
}