using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;

namespace AndroidFileIO
{
    [Activity(Label = "AndroidFileIO", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnWriteFile, btnReadFile;
        EditText etGetText;
        TextView tvPutText;

        string path = Application.Context.FilesDir.Path;
        string filePath;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetupViews();

            filePath = Path.Combine(path, "myTextFile.txt");

            btnWriteFile.Click += delegate
            {
                WriteText();
            };

            btnReadFile.Click += delegate
            {
                ReadText();
            };

        }

        void WriteText()
        {
            File.WriteAllText(filePath, etGetText.Text);
            etGetText.Text = "";
        }

        void ReadText()
        {
            if (File.Exists(filePath))
            {
                tvPutText.Text = File.ReadAllText(filePath);
            }
            else
            {
                tvPutText.Text = "File not found";
            }
        }

        void SetupViews()
        {
            btnReadFile = FindViewById<Button>(Resource.Id.btnReadFile);
            btnWriteFile = FindViewById<Button>(Resource.Id.btnWriteFile);

            etGetText = FindViewById<EditText>(Resource.Id.etGetText);
            tvPutText = FindViewById<TextView>(Resource.Id.tvPutText);
        }
    }
}

