using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidControls
{
    [Activity(Label = "AndroidControls", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ImageButton btnMenu;
        TextView tvPutResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            btnMenu.Click += BtnMenu_Click;

        }

        private void BtnMenu_Click(object sender, System.EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, btnMenu);
            menu.MenuInflater.Inflate(Resource.Drawable.menu_Items, menu.Menu);
            menu.MenuItemClick += Menu_MenuItemClick;
            menu.Show();
        }

        private void Menu_MenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs e)
        {
            string title = e.Item.TitleFormatted.ToString();

            switch (e.Item.ItemId)
            {
                case Resource.Id.btnCategory:
                    tvPutResult.Text = title;
                    break;
                case Resource.Id.btnDatabase:
                    tvPutResult.Text = title;
                    break;
                case Resource.Id.btnSecurity:
                    tvPutResult.Text = title;
                    break;
                case Resource.Id.btnAbout:
                    tvPutResult.Text = title;
                    break;
            }
        }

        void SetupViews()
        {
            btnMenu = FindViewById<ImageButton>(Resource.Id.btnMenu);
            tvPutResult = FindViewById<TextView>(Resource.Id.tvPutResult);
        }
    }
}

