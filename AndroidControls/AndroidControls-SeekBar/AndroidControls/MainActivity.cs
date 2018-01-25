using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        SeekBar sbSkillLevel;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            //sbSkillLevel.ProgressChanged += SbSkillLevel_ProgressChanged;

            sbSkillLevel.ProgressChanged += delegate
            {
                tvPutResult.Text = sbSkillLevel.Progress.ToString();
            };

        }

        //private void SbSkillLevel_ProgressChanged(object sender, SeekBar.ProgressChangedEventArgs e)
        //{
        //    tvPutResult.Text = e.Progress.ToString();
        //}

        void SetupViews()
        {
            sbSkillLevel = FindViewById<SeekBar>(Resource.Id.sbSkillLevel);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

