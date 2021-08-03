using CapitalLifeIndonesia.Services;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Appointment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPopUp : Rg.Plugins.Popup.Pages.PopupPage
    {
        public AddPopUp()
        {
            InitializeComponent();
        }

        private void CreateAppoinment_Clicked(object sender, EventArgs e)
        {
            var title = etTitle.Text;
            var date = DatePicker.Date.ToString();
            var time = TImePicker.Time.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time))
            {
                DependencyService.Get<IMessage>().ShortAlert("Semua Inputan Harus di isi");
            }
            else
            {
                navToApoointment();
            }
        }

        private async void navToApoointment()
        {
            Navigation.PopPopupAsync();
            await Navigation.PushAsync(new StatusPage());
        }
    }
}