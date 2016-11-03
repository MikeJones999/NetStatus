using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Plugin.Connectivity.Abstractions;

namespace NetStatus
{
    public class App : Application
    {
        public App()
        {
            //set the main page based upon the status of the connection
            MainPage = CrossConnectivity.Current.IsConnected ?  (Page) new NetworkViewPage() : new NoNetworkPage();
        }

        protected override void OnStart()
        {
            base.OnStart();
            CrossConnectivity.Current.ConnectivityChanged += connectionChanged;
        }

        void connectionChanged(object sender, ConnectivityChangedEventArgs e)
        {
            //gets main page currently showing
            Type currentPage = this.MainPage.GetType();
            if (e.IsConnected && currentPage != typeof(NetworkViewPage))
                this.MainPage = new NetworkViewPage();
            else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
            {
                this.MainPage = new NoNetworkPage();
            }

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
