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

namespace AndroidListView
{
    class CustomListAdapter : BaseAdapter<RowItems>
    {
        List<RowItems> mItems;
        Context mContext;

        public CustomListAdapter(Context context, List<RowItems> items)
        {
            mContext = context;
            mItems = items;
        }

        public override int Count
        {
            get { return mItems.Count(); }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override RowItems this[int position]
        {
            get { return mItems[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if(view == null)
            {
                view = LayoutInflater.From(mContext).Inflate(Resource.Layout.rowCustomItem, null, false);
            }

            TextView tvNumber = view.FindViewById<TextView>(Resource.Id.tvNumber);
            tvNumber.Text = mItems[position].Number.ToString();

            TextView tvName = view.FindViewById<TextView>(Resource.Id.tvName);
            tvName.Text = mItems[position].Name;

            return view;
        }
    }

    class RowItems
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public RowItems(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}