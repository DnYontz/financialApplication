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
    [Activity(Label = "AddTransactionActivity")]
    public class AddTransactionActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddTransactionLayout);

            var backToMainButton = FindViewById<Button>(Resource.Id.backToMainButton);
            backToMainButton.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };

            // Create your application here
        }
    }
}