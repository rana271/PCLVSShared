#if Andriod
using Android;
using Android.Widget;
#endif
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if __IOS__
using UIKit;
#endif
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace PCLVSShared
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    HelloWorld.TextColor = Color.Red;
                    break;
                case Device.Android:
                    HelloWorld.TextColor = Color.Blue;
                    break;
                case Device.UWP:
                case Device.macOS:
                default:
                    // This is just an example. You wouldn't actually need to do this, since Padding is already 0 by default.
                    HelloWorld.TextColor = Color.Green;
                    break;
            }
#if __IOS__

            UILabel uILabel = new UILabel();
            uILabel.Text = "Hello world";

#endif
#if Andriod
            //Android.Content.Context  content = null;
            //TextView currentCharacterName = new TextView(content);

            //currentCharacterName.Text = "Hello Andrid";

#endif
        }
    }
}
