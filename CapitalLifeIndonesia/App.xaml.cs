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
            CrossVonage.Current.UserToken = "T1==cGFydG5lcl9pZD00NzI1MjU0NCZzaWc9NGJiNWFiY2RhMzkwNDM3MzhmNzczMzE1YzVhMTVmYTliODg0NDgwYTpzZXNzaW9uX2lkPTFfTVg0ME56STFNalUwTkg1LU1UWXlORGsyTWpjMk1EazJPSDVHWTBObWFqSlNkMjVSU2k5aEx6aFhZM3BNVG5CNWRUUi1mZyZjcmVhdGVfdGltZT0xNjI0OTYyNzg2Jm5vbmNlPTAuMzg1NDEzNTExODI3MjkxOSZyb2xlPXB1Ymxpc2hlciZleHBpcmVfdGltZT0xNjI0OTY2Mzg1JmluaXRpYWxfbGF5b3V0X2NsYXNzX2xpc3Q9";
            CrossVonage.Current.SessionId = "1_MX40NzI1MjU0NH5-MTYyNDk2Mjc2MDk2OH5GY0NmajJSd25RSi9hLzhXY3pMTnB5dTR-fg";
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
