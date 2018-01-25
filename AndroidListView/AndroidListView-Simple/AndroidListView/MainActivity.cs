using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace AndroidListView
{
    [Activity(Label = "AndroidListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView lvDays;
        TextView tvItemSelected;

        string[] days;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            lvDays.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, days);
            lvDays.ItemClick += LvDays_ItemClick;

        }

        private void LvDays_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            tvItemSelected.Text = $"You choose {days[e.Position]}";
        }


        void SetupViews()
        {
            lvDays = FindViewById<ListView>(Resource.Id.lvDays);
            tvItemSelected = FindViewById<TextView>(Resource.Id.tvItemSelected);
        }
    }
}

