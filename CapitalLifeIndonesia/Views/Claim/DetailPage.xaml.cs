using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Claim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private bool status;

        public DetailPage(bool status)
        {
            this.status = status;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            if (status)
            {
                BorderStatus.BackgroundColor = Color.FromHex("3300CF15");
                TextStatus.TextColor = Color.FromHex("00CF15");
                TextStatus.Text = "Active";
                Submit.Text = "Claim";
            } else
            {
                BorderStatus.BackgroundColor = Color.FromHex("33F59C1A");
                TextStatus.TextColor = Color.FromHex("F59C1A");
                TextStatus.Text = "On Proggress";
                Submit.Text = "Fill Document";
            }
        }


        private async void OnVideoCall(object sender, EventArgs e)
        {
            /*if (!CrossVonage.Current.TryStartSession())
            {
                return;
            }*/
            if (this.status)
            {
                await Navigation.PushAsync(new VideoCallPage());
            } else
            {

            }
            
        }

        private async void OnClickBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}