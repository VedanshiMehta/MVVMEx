using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using DotLiquid.Util;
using MVVMEx.ViewModel;
using System;

namespace MVVMEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ViewModelMain viewModel;
        private EditText userNameET;
        private  EditText userPassET;
        private Button loginButton;
   

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            viewModel = new ViewModelMain(this);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
      
            UIReference();
          
          
    
        }

      
    
        

    
        

        private void UIReference()
        {
            loginButton = FindViewById<Button>(Resource.Id.login_);
            userNameET = FindViewById<EditText>(Resource.Id.inEmail);
            userPassET= FindViewById<EditText>(Resource.Id.inPassword);

            loginButton.Click += LoginButton_Click;

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            viewModel.SetUSerEmail(userNameET.Text);
            viewModel.SetUSerPassword(userPassET.Text);

            var message = viewModel.OnButtonClicked();
         
            
          
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}