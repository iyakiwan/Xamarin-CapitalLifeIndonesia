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
            CrossVonage.Current.UserToken = "T1==cGFydG5lcl9pZD00NzI1MjU0NCZzaWc9NGQxODRiM2M0YTg4YTNhZmVmNDBhMDg2ODdmZGY5YWU4N2NiZmZkMjpzZXNzaW9uX2lkPTFfTVg0ME56STFNalUwTkg1LU1UWXlORFl5TURReU9URTVPWDVpWVVkeWJ6RjFTRU5HTTI5RVJUQXpNM05CTTBWM1VYTi1VSDQmY3JlYXRlX3RpbWU9MTYyNDYyMDQ1OCZub25jZT0wLjE3OTc1MTgxNTUwMjEyNzgyJnJvbGU9cHVibGlzaGVyJmV4cGlyZV90aW1lPTE2MjQ2MjQwNTcmaW5pdGlhbF9sYXlvdXRfY2xhc3NfbGlzdD0=";
            CrossVonage.Current.SessionId = "1_MX40NzI1MjU0NH5-MTYyNDYyMDQyOTE5OX5iYUdybzF1SENGM29ERTAzM3NBM0V3UXN-UH4";
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
