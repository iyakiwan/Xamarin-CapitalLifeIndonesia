using CapitalLifeIndonesia.Services;
using CapitalLifeIndonesia.Views.Initial;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            CrossVonage.Current.ApiKey = "47252544";
            CrossVonage.Current.UserToken = "T1==cGFydG5lcl9pZD00NzI1MjU0NCZzaWc9ZDMxOTZkNGFiOWVmZDI5NDBkM2NiY2ZjZjViNWE0OThjNzg4NzVkMzpzZXNzaW9uX2lkPTJfTVg0ME56STFNalUwTkg1LU1UWXlOVGd4TVRZd05USTRObjQ1YUZkSkwxaG5lRnBXZEVsTVRFRm5hemhEWWxSVGJIWi1mZyZjcmVhdGVfdGltZT0xNjI1ODExNjIzJm5vbmNlPTAuMDU5NjE5NDQ0MjQ5NDAxMTMmcm9sZT1wdWJsaXNoZXImZXhwaXJlX3RpbWU9MTYyNTgzMzIyMSZpbml0aWFsX2xheW91dF9jbGFzc19saXN0PQ==";
            CrossVonage.Current.SessionId = "2_MX40NzI1MjU0NH5-MTYyNTgxMTYwNTI4Nn45aFdJL1hneFpWdElMTEFnazhDYlRTbHZ-fg";
            CrossVonage.Current.Error += (m) => MainPage.DisplayAlert("ERROR", m, "OK");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
