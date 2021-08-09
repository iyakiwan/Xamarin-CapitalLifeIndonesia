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
            CrossVonage.Current.ApiKey = "47300074";
            CrossVonage.Current.UserToken = "T1==cGFydG5lcl9pZD00NzMwMDA3NCZzaWc9ZWM1NDM1NTY0NWI0ZGU0MmU3ZDI4NTNlNDZkNWVmMTkxMjIxNzNjNjpzZXNzaW9uX2lkPTJfTVg0ME56TXdNREEzTkg1LU1UWXlPREkwTURVMk9EWTRNSDVFUkRNM1drbFlTbWxNTVVGUmFtaE9XVlY0Y0M5MmNpOS1mZyZjcmVhdGVfdGltZT0xNjI4MjQwNTgyJm5vbmNlPTAuNDk3NDI1NzYzNDA5MjU2OSZyb2xlPXB1Ymxpc2hlciZleHBpcmVfdGltZT0xNjI4MjQ0MTc5JmluaXRpYWxfbGF5b3V0X2NsYXNzX2xpc3Q9";
            CrossVonage.Current.SessionId = "2_MX40NzMwMDA3NH5-MTYyODI0MDU2ODY4MH5ERDM3WklYSmlMMUFRamhOWVV4cC92ci9-fg";
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
