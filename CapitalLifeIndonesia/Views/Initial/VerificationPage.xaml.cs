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
        public VerificationPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void LabelResend_Tapped(object sender, EventArgs e)
        {
            //Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            var input1 = tvNumber1.Text;
            var input2 = tvNumber2.Text;
            var input3 = tvNumber3.Text;
            var input4 = tvNumber4.Text;

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2) || string.IsNullOrEmpty(input3) || string.IsNullOrEmpty(input4))
            {
                DependencyService.Get<IMessage>().ShortAlert("Verifikasi Token");
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

        private async void LabelFailed_Tapped(object sender, EventArgs e)
        {
            //Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            await Navigation.PushPopupAsync(new VerifyFailPage());
        }
    }
}