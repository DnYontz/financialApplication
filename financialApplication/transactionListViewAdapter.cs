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
using Java.Lang;

namespace financialApplication
{
    class transactionListViewAdapter : BaseAdapter
    {
        private Activity Activity;
        private List<Transaction> Transactions;

        public transactionListViewAdapter(Activity activity, List<Transaction> transactions)
        {
            this.Activity = activity;
            this.Transactions = transactions;
        }

        public override int Count
        {
            get
            {
                return Transactions.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return Transactions[position].ID;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? Activity.LayoutInflater.Inflate(Resource.Layout.transactionListViewTemplate, parent, false);
            var TransactionName = view.FindViewById<TextView>(Resource.Id.TransactionNameText);
            var TransactionDate = view.FindViewById<TextView>(Resource.Id.TransactionDateText);
            var TransactionAmount = view.FindViewById<TextView>(Resource.Id.TransactionAmountText);

            TransactionName.Text = Transactions[position].TransactionName;
            TransactionDate.Text = Transactions[position].TransactionDate.ToString("MM/dd/yyyy hh:mm:ss");
            TransactionAmount.Text = Transactions[position].TransactionAmount.ToString("C2");

            return view;
        }
    }
}