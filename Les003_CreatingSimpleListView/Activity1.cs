using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Les003_CreatingSimpleListView
{
    [Activity(Label = "Les003_CreatingSimpleListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private ListView lViewItems;
        private List<string> lstItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            lstItems = new List<string>();
            lstItems.Add("Oleg");
            lstItems.Add("Alex");
            lstItems.Add("Olga");
            
            lViewItems = FindViewById<ListView>(Resource.Id.listViewItems);
            var adapter = new MyListViewAdapter(this, lstItems);
            lViewItems.Adapter = adapter;
        }
    }
}

