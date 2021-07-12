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
                IconSource = "contacts.png",
                TargetType = typeof(DashboardPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Customer",
                IconSource = "todo.png",
                TargetType = typeof(CustomerPage)
            });
            listView.ItemsSource = masterPageItems;
        }
    }
}