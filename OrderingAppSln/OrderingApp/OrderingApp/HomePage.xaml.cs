using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderingApp
{

    public class Style
    {
        public string Image { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public Style(string image, string color, string description)
        {
            Image = image;
            Color = color;
            Description = description;
        }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<Style> Styles { get; set;  }

       
        public HomePage()
        {
            InitializeComponent();

            Styles = new ObservableCollection<Style>
            {
                new Style("white.jpeg", "white", "Mens short sleeved white t-shirt"),
                new Style("grey.jpeg", "white", "Mens short sleeved gray t-shirt"),
                new Style("black.jpeg", "white", "Mens short sleeved black t-shirt"),
                new Style("wwhite.jpeg", "white", "Womens short sleeved white t-shirt"),
                new Style("wblack.jpeg", "white", "Womens short sleeved black t-shirt"),
                
            };

            BindingContext = this;
        }
    }
}