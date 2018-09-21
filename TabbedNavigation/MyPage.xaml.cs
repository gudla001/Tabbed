using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;


namespace TabbedNavigation
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MyPage)}:  ctor");
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnAppearing)}");
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDisappearing)}");
        }
    }
}
