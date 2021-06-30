﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Claim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClaimPage : ContentPage
    {
        public ClaimPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnClickBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StatusPage());
        }
    }
}