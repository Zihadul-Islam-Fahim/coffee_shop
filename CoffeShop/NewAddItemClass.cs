using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class NewAddItemClass
    {
        private string category;
        private string itemName;
        private string price;

        public string Category { get => category; set => category = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string Price { get => price; set => price = value; }
    }
}
