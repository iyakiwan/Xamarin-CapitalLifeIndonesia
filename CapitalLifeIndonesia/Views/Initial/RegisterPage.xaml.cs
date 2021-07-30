using CapitalLifeIndonesia.Services;
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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonRegister_Clicked(object sender, EventArgs e)
        {
            var username = etUsername.Text;
            var nik = etNIK.Text;
            var ttl = etTTL.Text;
            var email = etEmail.Text;
            var wa = etNoWhatsApp.Text;
            var phone = etNumberPhone.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(nik) || string.IsNullOrEmpty(ttl) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(wa) || string.IsNullOrEmpty(phone))
            {
                DependencyService.Get<IMessage>().ShortAlert("Semua Inputan Harus di isi");
            }
            else
            {
                navToVerification();
            }
        }

        private async void navToVerification()
        {
            await Navigation.PushAsync(new VerificationPage());
        }
    }
}