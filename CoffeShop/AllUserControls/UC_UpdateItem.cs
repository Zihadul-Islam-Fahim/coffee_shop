using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop.AllUserControls
{
    public partial class UC_UpdateItem : UserControl
    {
        List<NewAddItemClass> itemList = null;
        NewAddItemGateway newAddItemGateway = new NewAddItemGateway();
        public UC_UpdateItem()
        {
            InitializeComponent();
        }

        private void UC_UpdateItem_Load(object sender, EventArgs e)
        {
            reload();
        }
        public void reload()
        {
            itemList = newAddItemGateway.RetrieveritemList();
            updateGridView.DataSource = itemList;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void updateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Price.Text = itemList[e.RowIndex].Price;
            category.Text = itemList[e.RowIndex].Category;
            name.Text = itemList[e.RowIndex].ItemName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAddItemGateway newAddItemGateway = new NewAddItemGateway();
            newAddItemGateway.updateItem(Price.Text, name.Text);
            reload();
            MessageBox.Show(" Update Succesfully");
        }
    }
}
