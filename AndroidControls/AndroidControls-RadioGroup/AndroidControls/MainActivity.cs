using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        RadioGroup rgCities;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            rgCities.CheckedChange += RgCities_CheckedChange;
        }

        private void RgCities_CheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            var rbCity = FindViewById<RadioButton>(e.CheckedId);
            tvPutResult.Text = rbCity.Text;
        }

        void SetupViews()
        {
            rgCities = FindViewById<RadioGroup>(Resource.Id.rgCities);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

