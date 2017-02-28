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
            addTransactionButton.Click += AddTransactionButton_Click1;

            var transactionDetailsButton = FindViewById<Button>(Resource.Id.transactionDetailsButton);
            transactionDetailsButton.Click += TransactionDetailsButton_Click;




            // Set our view from the "main" layout resource

        }

        private void TransactionDetailsButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(TransactionDetailsActivity));
        }

        private void AddTransactionButton_Click1(object sender, System.EventArgs e)
        {
            StartActivity(typeof(AddTransactionActivity));
        }
    }
}

