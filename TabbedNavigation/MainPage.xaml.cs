using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MainPage)}:  ctor");
        }

        void OnAppearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnAppearing)}");
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDisappearing)}");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://en.wikipedia.org/wiki/Bulldogt"));
        }
    }
}
