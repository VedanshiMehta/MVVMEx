using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMEx.Model
{
    class ModelClass
    {
        public string _email;
        public string _password;

        public ModelClass(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public String GetEmail()
        {
            return _email;
        }

        public void SetEmail(string email)
        {

            this._email = email;
        }

        public String GetPassword()
        {

            return _email;

        }

        public void SetPassword(string password)
        {
            this._password = password;
        }
    }
}