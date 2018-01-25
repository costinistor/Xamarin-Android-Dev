using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidActivity
{
    [Activity(Label = "Number2Activity")]
    public class Number2Activity : Activity
    {
        TextView tvPutData;
        Button btnClose;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ActivityNumber2);
            SetupViews();

            string textData = Intent.GetStringExtra("passData");
            textData = $"Hello, {textData}";
            tvPutData.Text = textData;

            // close all activities
            btnClose.Click += delegate
            {
                FinishAffinity();
            };
        }

        // closing current activity with android back button
        // and restart MainActivity
        public override void OnBackPressed()
        {
            base.OnBackPressed();
            Finish();
            StartActivity(typeof(MainActivity));
        }

        void SetupViews()
        {
            tvPutData = FindViewById<TextView>(Resource.Id.tvPutData);
            btnClose = FindViewById<Button>(Resource.Id.btnClose);
        }
    }
}