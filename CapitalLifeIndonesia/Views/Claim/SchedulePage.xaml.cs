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
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnVideoCall(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new VideoCallPage());
        }

        private async void OnClickBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}