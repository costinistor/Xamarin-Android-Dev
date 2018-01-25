using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace AndroidActivity
{
    [Activity(Label = "AndroidActivity", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnOpenActivity2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnOpenActivity2.Click += BtnOpenActivity2_Click;

        }

        private void BtnOpenActivity2_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Number2Activity));
            StartActivity(intent);
        }

        void SetupViews()
        {
            btnOpenActivity2 = FindViewById<Button>(Resource.Id.btnOpenActivity2);
        }
    }
}

