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
    public partial class CustomerPage : TabbedPage
    {
        public CustomerPage()
        {
            InitializeComponent();
            this.Children.Add(new ChatPage());
            this.Children.Add(new FaqPage());
        }
    }
}