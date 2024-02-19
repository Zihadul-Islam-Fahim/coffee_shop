using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class OrderClass
    {
        private String name;
        private int quantity;
        private int price;
        private String userName;
        private String saleDate;

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string UserName { get => userName; set => userName = value; }
        public string SaleDate { get => saleDate; set => saleDate = value; }
    }
}
