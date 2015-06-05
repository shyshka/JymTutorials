using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Les005_ListViewClickListeners
{
    [Activity(Label = "Les004_CreatingCustomListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private ListView lViewPersons;
        private List<Person> lstPersons;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            lstPersons = new List<Person>();
            lstPersons.Add(new Person
            {
                Name = "Oleg",
                LastName = "Shyshka",
                Age = "26",
                Gender = "M"
            });
            lstPersons.Add(new Person
            {
                Name = "Alex",
                LastName = "Petrov",
                Age = "22",
                Gender = "M"
            });
            lstPersons.Add(new Person
            {
                Name = "Olga",
                LastName = "Ivanova",
                Age = "21",
                Gender = "F"
            });
            
            lViewPersons = FindViewById<ListView>(Resource.Id.listViewPersons);

            MyListViewAdapter adapter = new MyListViewAdapter(this, lstPersons);
            lViewPersons.Adapter = adapter;
            lViewPersons.ItemClick += lViewPersons_ItemClick;
            lViewPersons.ItemLongClick += lViewPersons_ItemLongClick;
            
        }

        void lViewPersons_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(lstPersons[e.Position].LastName);
        }

      

        void lViewPersons_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(lstPersons[e.Position].Name);
        }
    }
}

