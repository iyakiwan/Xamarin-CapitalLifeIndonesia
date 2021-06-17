using CapitalLifeIndonesia.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CapitalLifeIndonesia.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}