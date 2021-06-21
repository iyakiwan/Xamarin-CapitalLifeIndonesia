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
    public partial class VerificationPage : ContentPage
    {
        public VerificationPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void LabelResend_Tapped(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            await Navigation.PushAsync(new MainTestPage());
        }
    }
}