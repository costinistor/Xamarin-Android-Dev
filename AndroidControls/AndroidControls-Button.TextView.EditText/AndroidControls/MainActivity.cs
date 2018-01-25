using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText etGetText;
        Button btnPrintText;
        TextView tvPutText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnPrintText.Click += BtnPrintText_Click;
        }

        private void BtnPrintText_Click(object sender, System.EventArgs e)
        {
            string getText = etGetText.Text;
            if (string.IsNullOrWhiteSpace(getText))
            {
                tvPutText.Text = "Your input field is empty";
            }
            else
            {
                tvPutText.Text = $"Hello, {getText}";
            }
        }

        void SetupViews()
        {
            etGetText = FindViewById<EditText>(Resource.Id.etGetText);
            btnPrintText = FindViewById<Button>(Resource.Id.btnPrintText);
            tvPutText = FindViewById<TextView>(Resource.Id.tvPutText);
        }
    }
}

