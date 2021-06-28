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
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.Children.Add(new MainTestPage());
            this.Children.Add(new Claim.MainPage());
            this.Children.Add(new Policy.MainPage());
            this.Children.Add(new Appointment.MainPage());
            this.Children.Add(new Payment.MainPage());
        }
    }
}