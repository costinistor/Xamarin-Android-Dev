using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidGridView
{
    class CustomGridAdapter : BaseAdapter<BoxColor>
    {
        List<BoxColor> mColors;
        Context mContext;

        public CustomGridAdapter(Context context, List<BoxColor> colors)
        {
            mContext = context;
            mColors = colors;
        }

        public override int Count
        {
            get { return mColors.Count(); }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override BoxColor this[int position]
        {
            get { return mColors[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if(view == null)
            {
                view = LayoutInflater.From(mContext).Inflate(Resource.Layout.boxCustomColor, null, false);
            }

            TextView tvColor = view.FindViewById<TextView>(Resource.Id.tvColor);
            tvColor.Text = mColors[position].Number.ToString();
            string getColor = mColors[position].Color;

            //tvColor.SetBackgroundColor(Android.Graphics.Color.ParseColor(getColor));

            GradientDrawable bgBoxColor = new GradientDrawable();
            bgBoxColor.SetColor(Android.Graphics.Color.ParseColor(getColor));
            bgBoxColor.SetShape(ShapeType.Oval);
            tvColor.Background = bgBoxColor;

            return view;
        }
    }

    class BoxColor
    {
        public string Color { get; set; }
        public int Number { get; set; }

        public BoxColor(string color, int number)
        {
            Color = color;
            Number = number;
        }
    }
}