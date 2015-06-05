using Android.Content;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les003_CreatingSimpleListView
{
    class MyListViewAdapter:BaseAdapter <string>
    {
        private Context _cont;
        private List<string> _lstItems;

        public MyListViewAdapter(Context cont, List<string> lstItems)
        {
            this._cont = cont;
            this._lstItems = lstItems;
        }

        public override string this[int position]
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
            if (row == null) row = LayoutInflater.From(_cont).Inflate(Resource.Layout.listview_row, null, false);
            TextView tviewName = row.FindViewById<TextView>(Resource.Id.textViewName);
            tviewName.Text = _lstItems[position];
            return row;
        }
    }
}
