using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderListPage : ContentPage, INotifyPropertyChanged
    {
        private List<PlaceOrder> _placeOrders;

        public List<PlaceOrder> PlaceOrders
        {
            get { return _placeOrders; }
            set { _placeOrders = value;
                OnPropertyChanged("PlaceOrders");
                }
        }
        public OrderListPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TshirtOrdersDatabase db = TshirtOrdersDatabase.Instance;
            PlaceOrders = db.GetOrders();
        }
    }
}