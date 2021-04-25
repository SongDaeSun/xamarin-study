﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using xamarin_practice.Droid;

[assembly: Dependency(typeof(Caller_Android))]

namespace xamarin_practice.Droid
{
    class Caller_Android : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("안드로이드에서 전화를 겁니다");
            return true;
        }
    }
}