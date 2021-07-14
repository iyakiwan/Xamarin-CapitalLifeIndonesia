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
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            BindingContext = new ListViewDataModelViewModel();
        }

        public class ListViewDataModelViewModel : BindableObject
        {
            private List<ListItem> lstItems;
            public ListViewDataModelViewModel()
            {
                lstItems = new List<ListItem>
                {
                    new ListItem { Chat="Mystic" },
                    new ListItem { Chat="Instinct" },
                    new ListItem { Chat="Valor" }
                };
            }
            public List<ListItem> ListItems
            {
                get { return lstItems; }
                set
                {
                    lstItems = value;
                    OnPropertyChanged("listViewChat");
                }
            }

        }

        public class ListItem
        {
            public string Chat { get; set; }
        }

    }
}