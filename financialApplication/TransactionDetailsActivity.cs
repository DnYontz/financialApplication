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

namespace financialApplication
{
    [Activity(Label = "Transaction Details Activity")]
    public class TransactionDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TransactionDetailsLayout);

            var secondBackToMainButton = FindViewById<Button>(Resource.Id.secondBackToMainButton);
            secondBackToMainButton.Click += SecondBackToMainButton_Click;
            // Create your application here
        }

        private void SecondBackToMainButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}