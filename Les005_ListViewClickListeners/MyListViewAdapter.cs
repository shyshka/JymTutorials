using Android.Content;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les005_ListViewClickListeners
{
    class MyListViewAdapter:BaseAdapter<Person>
    {
        private Context _cont;
        private List<Person> _lstItems;

        public MyListViewAdapter(Context cont, List<Person> lstItems)
        {
            this._cont = cont;
            this._lstItems = lstItems;
        }

        public override Person this[int position]
        {
            get { return _lstItems[position]; }
        }

        public override int Count
        {
            get { return _lstItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Android.Views.View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
                row = LayoutInflater.From(_cont).Inflate(Resource.Layout.listview_row, null, false);

            TextView tViewName = row.FindViewById<TextView>(Resource.Id.textViewName);
            tViewName.Text = _lstItems[position].Name;

            TextView tViewLastName = row.FindViewById<TextView>(Resource.Id.textViewLastName);
            tViewLastName.Text = _lstItems[position].LastName;

            TextView tViewAge = row.FindViewById<TextView>(Resource.Id.textViewAge);
            tViewAge.Text = _lstItems[position].Age;

            TextView tViewGender = row.FindViewById<TextView>(Resource.Id.textViewGender);
            tViewGender.Text = _lstItems[position].Gender;

            return row;
        }
    }
}
