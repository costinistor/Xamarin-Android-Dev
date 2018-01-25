using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace AndroidToastAndDialog
{
    [Activity(Label = "AndroidToastAndDialog", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnAlertDialog1, btnAlertDialog2, btnAlertDialog3;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnAlertDialog1.Click += BtnAlertDialog1_Click;
            btnAlertDialog2.Click += BtnAlertDialog2_Click;
            btnAlertDialog3.Click += BtnAlertDialog3_Click;
        }

        private void BtnAlertDialog3_Click(object sender, System.EventArgs e)
        {
            AlertDialog.Builder alertBuilder = new AlertDialog.Builder(this);
            alertBuilder.SetTitle("My Alert Dialog");
            alertBuilder.SetMessage("This is an alert dialog message");
            alertBuilder.SetPositiveButton("Yes", (s, args) =>
            {
                ShowToast("Yes");
                // do something
            });
            alertBuilder.SetNegativeButton("No", (s, args) =>
            {
                ShowToast("No");
                // do something
            });
            alertBuilder.SetNeutralButton("Cancel", (s, args) =>
            {
                ShowToast("Cancel");
                // do something
            });
            Dialog dialog = alertBuilder.Create();
            dialog.Show();
        }

        private void BtnAlertDialog2_Click(object sender, System.EventArgs e)
        {
            AlertDialog.Builder alertBuilder = new AlertDialog.Builder(this);
            alertBuilder.SetTitle("My Alert Dialog");
            alertBuilder.SetMessage("This is an alert dialog message");
            alertBuilder.SetPositiveButton("Yes", (s, args) =>
            {
                ShowToast("Yes");
                // do something
            });
            alertBuilder.SetNegativeButton("No", (s, args) =>
            {
                ShowToast("No");
                // do something
            });
            Dialog dialog = alertBuilder.Create();
            dialog.Show();
        }

        private void BtnAlertDialog1_Click(object sender, System.EventArgs e)
        {
            AlertDialog.Builder alertBuilder = new AlertDialog.Builder(this);
            alertBuilder.SetTitle("My Alert Dialog");
            alertBuilder.SetMessage("This is an alert dialog message");
            alertBuilder.SetPositiveButton("Yes", (s, args) =>
            {
                ShowToast("Yes");
                // do something
            });
            Dialog dialog = alertBuilder.Create();
            dialog.Show();
        }

        void ShowToast(string textButton)
        {
            var toast = Toast.MakeText(this, $"You choosed {textButton} button", ToastLength.Short);
            toast.Show();
        }

        void SetupViews()
        {
            btnAlertDialog1 = FindViewById<Button>(Resource.Id.btnAlertDialog1);
            btnAlertDialog2 = FindViewById<Button>(Resource.Id.btnAlertDialog2);
            btnAlertDialog3 = FindViewById<Button>(Resource.Id.btnAlertDialog3);
        }
    }
}

