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

            var backButton = FindViewById<Button>(Resource.Id.backButton);
            backButton.Click += BackButton_Click;


            var transactionListView = FindViewById<ListView>(Resource.Id.transactionListView);
            List<Transaction> transactions = new List<Transaction>();

            for (int i = 0; i < 20; i++) {
                Transaction transaction = new Transaction();
                transaction.ID = i + 1;
                transaction.TransactionAmount = (i + 1) * 2.45;
                transaction.TransactionName = "Place " + 1;
                transaction.TransactionDate = DateTime.Now;
                transactions.Add(transaction);

            }

            var adapter = new transactionListViewAdapter(this, transactions);

            transactionListView.Adapter = adapter;



        }

        

        private void BackButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}