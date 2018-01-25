using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Spinner spnCarBrands;
        TextView tvPutResult;

        string[] mCars;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            mCars = Resources.GetStringArray(Resource.Array.m_cars);

            ArrayAdapter adapter = ArrayAdapter.CreateFromResource(
                this, Resource.Array.m_cars, Resource.Layout.spinnerSelectedItem
                );
            adapter.SetDropDownViewResource(Resource.Layout.spinnerDropDownItem);
            spnCarBrands.Adapter = adapter;

            spnCarBrands.ItemSelected += SpnCarBrands_ItemSelected;

        }

        private void SpnCarBrands_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            tvPutResult.Text = mCars[e.Position];
        }

        void SetupViews()
        {
            spnCarBrands = FindViewById<Spinner>(Resource.Id.spnCarBrands);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

