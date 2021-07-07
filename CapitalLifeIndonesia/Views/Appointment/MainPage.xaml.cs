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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListView.SetValue(IsVisibleProperty, false);
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }

        private void TapEmpty_Tapped(object sender, EventArgs e)
        {
            EmptyView.SetValue(IsVisibleProperty, false);
            ListView.SetValue(IsVisibleProperty, true);
        }

        private async void Notification_Appointment_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notification.MainPage());
        }
    }
}