using Android.App;
using Android.Widget;
using Android.OS;

namespace financialApplication
{
    [Activity(Label = "financialApplication", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var addTransactionButton = FindViewById<Button>(Resource.Id.addTransactionButton);
            addTransactionButton.Click += delegate {
                StartActivity(typeof(AddTransactionActivity));

            };

            // Set our view from the "main" layout resource

        }
    }
}

