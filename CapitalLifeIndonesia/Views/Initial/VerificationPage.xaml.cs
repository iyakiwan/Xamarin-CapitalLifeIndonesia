using CapitalLifeIndonesia.Services;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Initial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerificationPage : ContentPage
    {
        INotificationManager notificationManager;
        public VerificationPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            notificationManager = DependencyService.Get<INotificationManager>();

            string title = "Token Autentifikasi";
            string message = "Berikut ini code tokennya: 1234";
            notificationManager.SendNotification(title, message);
        }

        private void LabelResend_Tapped(object sender, EventArgs e)
        {
            var input1 = tvNumber1.Text;
            var input2 = tvNumber2.Text;
            var input3 = tvNumber3.Text;
            var input4 = tvNumber4.Text;

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3) || string.IsNullOrEmpty(input4))
            {
                DependencyService.Get<IMessage>().ShortAlert("Verifikasi Token");
            }
            else if (!input1.Equals("1") || !input2.Equals("2") || !input3.Equals("3") || !input4.Equals("4"))
            {
                navFail();
            }
            else
            {
                navMain();
            }
            
        }

        private async void navMain()
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void navFail()
        {
            await Navigation.PushPopupAsync(new VerifyFailPage());
        }

        private async void LabelFailed_Tapped(object sender, EventArgs e)
        {
            //Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            navFail();
        }
    }
}