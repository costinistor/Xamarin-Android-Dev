using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ToggleButton tbOnOff;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            tbOnOff.CheckedChange += TbOnOff_CheckedChange;

        }

        private void TbOnOff_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            // using ternary operator as a shortcut for an if...else statement
            tvPutResult.Text = (e.IsChecked) ? "Your button is ON" : "Your button is OFF";
        }

        void SetupViews()
        {
            tbOnOff = FindViewById<ToggleButton>(Resource.Id.tbOnOff);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

