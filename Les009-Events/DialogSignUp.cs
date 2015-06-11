using Android.App;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les009_Events
{
    public class DialogSignUp : DialogFragment
    {
        private EditText txtFirstName;
        private EditText txtEmail;
        private EditText txtPassword;
        private Button btnSignUp;

        public event EventHandler<OnSignUpEventsArgs> SignUpPressed;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.DialogSignUp, container, false);
            txtFirstName = view.FindViewById<EditText>(Resource.Id.txtFirstName);
            txtEmail = view.FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = view.FindViewById<EditText>(Resource.Id.txtPassword);
            btnSignUp = view.FindViewById<Button>(Resource.Id.btnSignUp);
            btnSignUp.Click += btnSignUp_Click;
            return view;
        }

        void btnSignUp_Click(object sender, EventArgs e)
        {
            if (SignUpPressed != null)
            {
                SignUpPressed.Invoke(this, new OnSignUpEventsArgs(
                    txtFirstName.Text,
                    txtEmail.Text,
                    txtPassword.Text));
            }
            this.Dismiss();
        }

        public override void OnActivityCreated(Android.OS.Bundle savedInstanceState)
        {
            Dialog.Window.RequestFeature(Android.Views.WindowFeatures.NoTitle);
            base.OnActivityCreated(savedInstanceState);
            Dialog.Window.Attributes.WindowAnimations = Resource.Style.dialogAnimation;
        }
    }

    public class OnSignUpEventsArgs : EventArgs
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public OnSignUpEventsArgs(string firstName, string eMail, string password) 
        {
            this.FirstName = firstName;
            this.Email = eMail;
            this.Password = password;
        }
    }
}
