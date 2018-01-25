using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Switch sthImage;
        ImageView imgAndroid;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            if (!sthImage.Checked)
            {
                imgAndroid.Visibility = Android.Views.ViewStates.Gone;
            }

            sthImage.CheckedChange += SthImage_CheckedChange;

        }

        private void SthImage_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (e.IsChecked)
            {
                imgAndroid.Visibility = Android.Views.ViewStates.Visible;
                tvPutResult.Text = "Image is visible";
            }else
            {
                imgAndroid.Visibility = Android.Views.ViewStates.Gone;
                tvPutResult.Text = "Image is invisible";
            }
        }

        void SetupViews()
        {
            sthImage = FindViewById<Switch>(Resource.Id.sthImage);
            imgAndroid = FindViewById<ImageView>(Resource.Id.imgAndroid);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

