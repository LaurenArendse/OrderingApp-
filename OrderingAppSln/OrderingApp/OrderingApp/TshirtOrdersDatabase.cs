using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace OrderingApp
{
    public class TshirtOrdersDatabase
    {
        private SQLiteConnection _database;

        public static TshirtOrdersDatabase Instance = new TshirtOrdersDatabase();


        public TshirtOrdersDatabase()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path = path + "order.db";

            _database = new SQLiteConnection(path, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache);

            _database.CreateTable<PlaceOrder>();
        }

        public List<PlaceOrder> GetOrders()
        {
            return _database.Table<PlaceOrder>().OrderByDescending(x=>x.Date).ToList();
        }

        public void SavePlaceOrder(PlaceOrder order)
        {
            _database.Insert(order);
        }
    }
}
