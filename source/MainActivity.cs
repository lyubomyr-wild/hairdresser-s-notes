using Android.App;
using Android.Widget;
using Android.OS;

namespace hairdresser_s_notes
{
    [Activity(Label = "hairdresser_s_notes", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

