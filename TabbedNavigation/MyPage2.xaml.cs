using System.Diagnostics;
using Xamarin.Forms;

namespace TabbedNavigation
{
    public partial class MyPage2 : TabbedPage
    {
        public MyPage2()
        {
            InitializeComponent();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MyPage2)}:  ctor");
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
