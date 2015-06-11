using Android.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les008_CreatingDialogFragment
{
    public class DialogSignUp : DialogFragment
    {
        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.DialogSignUp, container, false);            
            return view;
        }

        public override void OnActivityCreated(Android.OS.Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(Android.Views.WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialogAnimation;
        }
    }
}
