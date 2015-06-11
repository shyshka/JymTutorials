using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Les008_CreatingDialogFragment
{
    [Activity(Label = "Les008_CreatingDialogFragment", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var btnSignUp = FindViewById(Resource.Id.btnSignUp);
            btnSignUp.Click += delegate
                {
                    FragmentTransaction trans = FragmentManager.BeginTransaction();
                    //trans.SetCustomAnimations(Resource.Animation.bounce, Resource.Animation.bounce);
                    var dlg = new DialogSignUp();
                    dlg.Show(trans, "dialog fragment");
                };
        }
    }
}

