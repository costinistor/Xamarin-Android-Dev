using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace AndroidToastAndDialog
{
    [Activity(Label = "AndroidToastAndDialog", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnShortToast, btnLongToast;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnShortToast.Click += BtnShortToast_Click;
            btnLongToast.Click += BtnLongToast_Click;
        }

        private void BtnLongToast_Click(object sender, System.EventArgs e)
        {
            var toast = Toast.MakeText(this, "This is a long message in the center", ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }

        private void BtnShortToast_Click(object sender, System.EventArgs e)
        {
            var toast = Toast.MakeText(this, "This is a short message at the bottom", ToastLength.Short);
            toast.SetGravity(GravityFlags.Bottom, 0, 50);
            toast.Show();
        }

        void SetupViews()
        {
            btnLongToast = FindViewById<Button>(Resource.Id.btnLongToast);
            btnShortToast = FindViewById<Button>(Resource.Id.btnShortToast);
        }
    }
}

