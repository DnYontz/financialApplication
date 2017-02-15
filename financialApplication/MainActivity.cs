using Android.App;
using Android.Widget;
using Android.OS;

namespace financialApplication
{
    [Activity(Label = "Financial Application", MainLauncher = true, Icon = "@drawable/icon")]
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

            var transactionDetailsButton = FindViewById<Button>(Resource.Id.transactionDetailsButton);
            transactionDetailsButton.Click += delegate
            {
                StartActivity(typeof(TransactionDetailsActivity));
            };


            // Set our view from the "main" layout resource

        }
    }
}

