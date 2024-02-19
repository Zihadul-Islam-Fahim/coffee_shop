using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace CoffeShop.AllUserControls
{
    public partial class UC_additems : UserControl
    {

        public UC_additems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ItemName.Text == "")
            {
                MessageBox.Show("Item Name Required");
            }
            else if (ItemPrice.Text == "")
            {
                MessageBox.Show("Price Required");
            }
            else if (itemCategory.Text == "")
            {
                MessageBox.Show("Category Required");
            }
            else
            {
                NewAddItemClass newAddItemClass = new NewAddItemClass();
                newAddItemClass.Category = itemCategory.Text;
                newAddItemClass.ItemName = ItemName.Text;
                newAddItemClass.Price = ItemPrice.Text;


                NewAddItemGateway newAddItemGateway = new NewAddItemGateway();
                newAddItemGateway.InsertIntoItemsTable(newAddItemClass);
                MessageBox.Show("Item Added Succesfully");

            }
        }

        private void UC_additems_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
