using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Initial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTestPage : ContentPage
    {
        public MainTestPage()
        {
            InitializeComponent();

            Title = "Dashboard";
            /*if (!CrossVonage.Current.TryStartSession())
            {
                return;
            }*/
        }

        private async void BtnVidCall_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppShell());
        }
    }
}