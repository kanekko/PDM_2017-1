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
    [Activity(Label = "ListViewActivity")]
    public class ListViewActivity : Activity
    {
        List<CustomListItem> items;
        CustomAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListViewLayout);
            ListView listView = FindViewById<ListView>(Resource.Id.list);
            items = createItems();
            adapter = new CustomAdapter(this, items);
            listView.Adapter = adapter;
            listView.ItemClick += ListView_ItemClick;
            Button addButton = FindViewById<Button>(Resource.Id.addButton);
            addButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            items.Add(new CustomListItem("Item"+items.Count+1,"New item added on fly"));
            adapter.NotifyDataSetChanged();
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            CustomListItem item = ((CustomAdapter)listView.Adapter)[e.Position];
            Android.Widget.Toast.MakeText(this, item.title, Android.Widget.ToastLength.Short).Show();
            
        }

        private List<CustomListItem> createItems()
        {
            List<CustomListItem> items = new List<CustomListItem>();
            items.Add(new CustomListItem("Item 1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 4", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 5", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 6", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 7", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 8", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 9", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            items.Add(new CustomListItem("Item 10", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Nunc laoreet. "));
            return items;
        }
    }
}