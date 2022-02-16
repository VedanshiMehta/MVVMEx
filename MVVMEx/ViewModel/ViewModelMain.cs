using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using MVVMEx.Model;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MVVMEx.ViewModel
{
    class ViewModelMain : BaseViewModel, INotifyPropertyChanged

    {
        private readonly ModelClass model;

        Context context;

        private readonly string success = "Login Sucessfull";
        private readonly string errormessage = "Email or password is not valid";

       // private string toast = null;

        public ViewModelMain(MainActivity mainActivity)
        {
            this.context = mainActivity;
            model = new ModelClass("", "");
        }

        /*public string GetToasMessage()
        {
            return toast;
        }

        public void SetToastMessage(string toastMessage)
        {
   
            this.toast = toastMessage;
            OnPropertyChanged(toastMessage);

        }*/

        public string GetUserEmail()
        {
            return model.GetEmail();

        }

        public void SetUSerEmail(string email)
        {
            model.SetEmail(email);
            OnPropertyChanged(email);
        }


        public string GetUserPassword()
        {
            return model.GetPassword();

        }

        public void SetUSerPassword(string pass)
        {
            model.SetPassword(pass);
            OnPropertyChanged(pass);
        }


        public bool OnButtonClicked()
        {

            if (IsValid())
            {
                Toast.MakeText(context, success, ToastLength.Short).Show();
               // SetToastMessage(success);
                return true;
                
            }
            else
            {
                Toast.MakeText(context, errormessage, ToastLength.Short).Show();
                //SetToastMessage(errormessage);
                return false; 
               
            }

        }

        private bool IsValid()
        {
            return !TextUtils.IsEmpty(GetUserEmail()) && Patterns.EmailAddress.Matcher(GetUserEmail()).Matches() && GetUserPassword().Length > 5;
        }
    }



}
    
