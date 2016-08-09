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
    class HomeScreen : DialogFragment
    {


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            Button bill, stats;

            var View = inflater.Inflate(Resource.Layout.HomeScreenDesign, container, false);

            bill = View.FindViewById<Button>(Resource.Id.btnPayBill);

            bill.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog box
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                //dialogBill billDialog = new dialogBill();
                //dialogBill.Show(transaction, "dialog fragment");
            };

            stats = View.FindViewById<Button>(Resource.Id.btnViewUsage);

            stats.Click += (object sender, EventArgs args) =>
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                //dialogStats statsDialog = new dialogStats();
                //dialogStats.Show(transaction, "dialog fragment");
            };

            //Button mBtnSignIn =  View.FindViewById<Button>(Resource.Id.btnSignUp);
            //mBtnSignIn.Click += (object sender, EventArgs args) => 
            //{
            //   Intent intent = new Intent(Context, Home.class);
            //  context.startActivity(intent);
            //};

            return View;
        }


    }
}