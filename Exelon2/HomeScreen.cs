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

namespace Exelon2
{
    class HomeScreen :Activity
    {
        private Button bill, stats;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.HomeScreenDesign);

            bill = FindViewById<Button>(Resource.Id.bill);

            bill.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog box
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialogBill billDialog = new dialogBill();
                dialogBill.Show(transaction, "dialog fragment");
            };

            stats = FindViewById<Button>(Resource.Id.stats);

            stats.Click += (object sender, EventArgs args) =>
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialogStats statsDialog = new dialogStats();
                dialogStats.Show(transaction, "dialog fragment");
            };
        }


    }
}