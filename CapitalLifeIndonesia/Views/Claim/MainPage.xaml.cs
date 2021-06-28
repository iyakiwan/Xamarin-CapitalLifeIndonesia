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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Claim";
        }

        private async void OnDetail(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailPage(true));
        }

        private async void OnDetailProggress(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailPage(false));
        }
    }
}