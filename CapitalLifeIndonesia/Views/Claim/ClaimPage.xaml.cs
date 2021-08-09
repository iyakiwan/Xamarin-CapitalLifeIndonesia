using CapitalLifeIndonesia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Claim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClaimPage : ContentPage
    {
        private String radioValue = "";

        public ClaimPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnClickBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            var fName = etFirstName.Text;
            var lName = etLastName.Text;
            var product = etProductName.Text;
            var policy = etPolicy.Text;
            var addres = etAddres.Text;
            var phone = etPhone.Text;
            var email = etEmail.Text;
            var claim = etClaim.Text;
            var date = startDatePicker.Date.ToString();

            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(product)
                || string.IsNullOrEmpty(policy) || string.IsNullOrEmpty(addres) || string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(claim) || string.IsNullOrEmpty(date)
                || string.IsNullOrEmpty(radioValue))
            {
                DependencyService.Get<IMessage>().ShortAlert("Semua Inputan Harus di isi");
            }
            else
            {
                navToSubmit();
            }
        }

        private async void navToSubmit()
        {
            await Navigation.PushAsync(new StatusPage());
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            radioValue = button.Content.ToString();
        }
    }
}