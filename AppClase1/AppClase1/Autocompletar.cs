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

namespace AppClase1
{
    [Activity(Label = "Autocompletar")]
    public class Autocompletar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var autoCompleteOptions = new String[] { "Hello", "Hey", "Heja", "Hi", "Hola", "Bonjour", "Gday", "Goodbye", "Sayonara", "Farewell", "Adios" };


            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Autocompletar);
            // Create your application here

            ArrayAdapter autoCompleteAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, autoCompleteOptions);
            var autocompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompletarTexto);
            autocompleteTextView.Adapter = autoCompleteAdapter;
        }
    }
}