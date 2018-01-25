using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace AndroidListView
{
    [Activity(Label = "AndroidListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView lvItems;
        TextView tvItemSelected;

        List<RowItems> mItems = new List<RowItems>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            for (int i = 0; i < 30; i++)
            {
                mItems.Add(new RowItems(i, $"Android application - {i}"));
            }

            CustomListAdapter adapter = new CustomListAdapter(this, mItems);
            lvItems.Adapter = adapter;

            lvItems.ItemClick += LvItems_ItemClick;

        }

        private void LvItems_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            tvItemSelected.Text = $"Row number {e.Position}";
        }

        void SetupViews()
        {
            lvItems = FindViewById<ListView>(Resource.Id.lvItems);
            tvItemSelected = FindViewById<TextView>(Resource.Id.tvItemSelected);
        }
    }
}

