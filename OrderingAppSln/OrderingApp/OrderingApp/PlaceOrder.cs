using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace OrderingApp
{
    public class PlaceOrder
    {

        public PlaceOrder()
        {
            Date = DateTime.Now;
        }

        [PrimaryKey, AutoIncrement]
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
    }
}
