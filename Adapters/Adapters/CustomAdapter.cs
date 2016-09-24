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

namespace Adapters
{
    public class CustomAdapter : BaseAdapter<CustomListItem>
    {
        List<CustomListItem> items;
        Activity context;
        public CustomAdapter(Activity context, List<CustomListItem> items) : base() {
            this.context = context;
            this.items = items;
        }

        public override CustomListItem this[int position]
        {
            get
            {
                return items[position];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is available
            if (view == null) // otherwise create a new one
                view = context.LayoutInflater.Inflate(Resource.Layout.ItemVIew, null);
            view.FindViewById<TextView>(Resource.Id.Text1).Text = items[position].title;
            view.FindViewById<TextView>(Resource.Id.Text2).Text = items[position].description;

            view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(items[position].image);
            return view;
        }
        
    }
}