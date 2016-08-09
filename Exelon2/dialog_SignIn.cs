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
    class dialog_SignIn : DialogFragment
    {
        

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var View = inflater.Inflate(Resource.Layout.dialog_sign_in, container, false);

            Button mBtnSignIn =  View.FindViewById<Button>(Resource.Id.btnSignIn);
            mBtnSignIn.Click += (object sender, EventArgs args) => 
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                HomeScreen home = new HomeScreen();
                home.Show(transaction, "home screen");

            };

            return View;
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(WindowFeatures.NoTitle); //Sets the title bar to invisible
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialog_animation; //sets the animation

        }

        public void login(View view)
        {
            //Intent intent = new Intent(this, Home.class );
            //startActivity(Intent);
        }

        
            };

}
