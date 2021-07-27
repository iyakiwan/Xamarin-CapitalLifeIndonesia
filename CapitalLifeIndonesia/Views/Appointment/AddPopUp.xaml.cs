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

        private async void CreateAppoinment_Clicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            await Navigation.PushAsync(new StatusPage());
        }
    }
}