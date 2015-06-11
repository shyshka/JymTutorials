using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;

namespace Les009_Events
{
    [Activity(Label = "Les009_Events", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private ProgressBar prBar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            prBar = FindViewById<ProgressBar>(Resource.Id.prBar);

            var btnSignUp = FindViewById(Resource.Id.btnSignUp);
            btnSignUp.Click += delegate
            {
                FragmentTransaction trans = FragmentManager.BeginTransaction();
                var dlg = new DialogSignUp();
                dlg.SignUpPressed += dlg_SignUpPressed;
                dlg.Show(trans, "dialog fragment");
            };
        }

        void dlg_SignUpPressed(object sender, OnSignUpEventsArgs e)
        {
            prBar.Visibility = ViewStates.Visible;
            Thread thread = new Thread(new ThreadStart(delegate
                {                        
                        Thread.Sleep(3000);
                        bool resCheck = AccountChecker.CheckAccountInfo(e.FirstName, e.Email, e.Password);
                        RunOnUiThread(delegate
                        {
                            Toast.MakeText(this, resCheck ? "yes" : "no", ToastLength.Long).Show();
                            prBar.Visibility = ViewStates.Invisible;
                        });
                }));
            thread.Start();
        }
    }
}

