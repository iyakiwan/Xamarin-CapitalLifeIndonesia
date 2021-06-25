using CapitalLifeIndonesia.ViewModels;
using CapitalLifeIndonesia.Views;
using CapitalLifeIndonesia.Views.Claim;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CapitalLifeIndonesia
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
            Routing.RegisterRoute(nameof(VideoCallPage), typeof(VideoCallPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
