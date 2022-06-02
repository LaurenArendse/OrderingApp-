using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public PlaceOrder Order { get; set; }

        public OrderPage()
        {
            InitializeComponent();

            Order = new PlaceOrder();
            BindingContext = Order;
        }

        private void PlaceOrderButton_Clicked(object sender, EventArgs e)
        {
            TshirtOrdersDatabase db = TshirtOrdersDatabase.Instance;

            db.SavePlaceOrder(Order);
        }
    }
}