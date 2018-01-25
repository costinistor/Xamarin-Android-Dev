using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        CheckBox cbBoxA, cbBoxB, cbBoxC;
        Button btnPrintResult;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnPrintResult.Click += delegate
            {
                tvPutResult.Text = checkResult();
            };

        }

        string checkResult()
        {
            string result = "";
            result += (cbBoxA.Checked) ? "Box A is checked \n" : "Box A is unchecked \n";
            result += (cbBoxB.Checked) ? "Box B is checked \n" : "Box B is unchecked \n";
            result += (cbBoxC.Checked) ? "Box C is checked \n" : "Box C is unchecked \n";
            return result;
        }

        void SetupViews()
        {
            cbBoxA = FindViewById<CheckBox>(Resource.Id.cbBoxA);
            cbBoxB = FindViewById<CheckBox>(Resource.Id.cbBoxB);
            cbBoxC = FindViewById<CheckBox>(Resource.Id.cbBoxC);

            btnPrintResult = FindViewById<Button>(Resource.Id.btnPrintResult);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

