using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace AndroidGridView
{
    [Activity(Label = "AndroidGridView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        GridView gvColors;
        TextView tvItemSelected;

        List<BoxColor> mColors = new List<BoxColor>();

        string[] colors;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            colors = new string[] { "#fc3c3c", "#f90404", "#9b0101", "#f92c63", "#f90446", "#9e012b", "#fc32ab", "#f90497", "#8e0156", "#f334f9",
                                    "#ef02f7", "#820187", "#ad48f9", "#8f02f9", "#560196", "#493cfc", "#1302fc", "#0c01a5", "#3f91fc", "#046ef7",
                                    "#014296", "#4af1f9", "#04ecf7", "#01888e", "#39f9a0", "#02f987", "#019350", "#50f940", "#19f704", "#0e9601" };

            for (int i = 0; i < colors.Length; i++)
            {
                mColors.Add(new BoxColor(colors[i], i));
            }

            CustomGridAdapter adapter = new CustomGridAdapter(this, mColors);
            gvColors.Adapter = adapter;

            gvColors.ItemClick += GvColors_ItemClick;

        }

        private void GvColors_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            tvItemSelected.SetBackgroundColor(Android.Graphics.Color.ParseColor(colors[e.Position]));
        }

        void SetupViews()
        {
            gvColors = FindViewById<GridView>(Resource.Id.gvColors);
            tvItemSelected = FindViewById<TextView>(Resource.Id.tvItemSelected);
        }
    }
}

