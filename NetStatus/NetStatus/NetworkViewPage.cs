using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetStatus
{
    class NetworkViewPage : ContentPage
    {

        public NetworkViewPage()
        {
            BackgroundColor = Color.FromRgb(0xf0, 0xf0, 0xf0);
            Content = new Label {

                Text = "Connection Details",
                TextColor = Color.FromRgb(0x40, 0x40, 0x40),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center

            };



        }

    }
}
