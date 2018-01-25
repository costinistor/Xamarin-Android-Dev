using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnReadText;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnReadText.Click += delegate
            {
                tvPutResult.Text = TextLoop();
            };

        }

        string TextLoop()
        {
            string text = "";
            for (int i = 0; i < 30; i++)
            {
                text += $"Hello, Android {i} \n";
            }
            return text;
        }


        void SetupViews()
        {
            btnReadText = FindViewById<Button>(Resource.Id.btnReadText);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

