using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CapitalLifeIndonesia.Views.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Dashboard",
                IconSource = "icon_dashboard.png",
                TargetType = typeof(DashboardPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Customer Support",
                IconSource = "icon_help.png",
                TargetType = typeof(CustomerPage)
            });
            listView.ItemsSource = masterPageItems;
        }

        private async void Logout_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Initial.LoginPage());
        }
    }
}