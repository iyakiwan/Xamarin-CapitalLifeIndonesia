using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Appointment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentView
    {
        public ListView()
        {
            InitializeComponent();
        }

        private async void ButtonJoin_Clicked(object sender, EventArgs e)
        {
            if (!CrossVonage.Current.TryStartSession())
            {
                return;
            }
            await Navigation.PushAsync(new Claim.VideoCallPage());
        }
    }
}