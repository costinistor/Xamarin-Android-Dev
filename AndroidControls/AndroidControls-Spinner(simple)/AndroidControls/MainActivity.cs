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

            mCars = new string[] { "Honda", "Fiat", "Toyota", "Mazda", "Peugeot", "Ferrari", "Jaguar"};

            spnCarBrands.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, mCars);
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

