using DGVPrinterHelper;
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
    public partial class UC_welcome : UserControl
    {

        int Gtotal = 0;
        int removedValue = 0;
        List<NewAddItemClass> categoryList = null;
        List<NewAddItemClass> itemList = null;

        List<NewAddItemClass> itemDetail = null;
        NewAddItemGateway newAddItemGateway = new NewAddItemGateway();
        public UC_welcome()
        {
            InitializeComponent();
        }

        private void UC_welcome_Load(object sender, EventArgs e)
        {
            reload();
            string p = CategoryCombobox.Text;

            ;
        }
        public void reload()
        {
            categoryList = newAddItemGateway.RetrieveContent();
            Console.WriteLine(categoryList.Count);
            Console.WriteLine(categoryList[0].Category.Length);
            for (int i = 0; i < categoryList[0].Category.Length; i++)
            {
                CategoryCombobox.Items.Add(categoryList[i].Category);


            }

        }

        private void CategoryCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void CategoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            itemList = newAddItemGateway.RetrieveCategorysItems(CategoryCombobox.Text);
            ItemListBox.Items.Clear();

            for (int i = 0; i < itemList.Count; i++)
            {
                ItemListBox.Items.Add(itemList[i].ItemName);
            }

        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemDetail = newAddItemGateway.RetrieveDetaisItem(ItemListBox.Text);
                itemName.Text = itemDetail[0].ItemName;
                price.Text = itemDetail[0].Price;
                total.Text = price.Text;
                quantityUpDown.Value = 1;
            }
            catch { }



        }

        private void quantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(quantityUpDown.Value) * Convert.ToInt32(itemDetail[0].Price);
            total.Text = t.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (price.Text != "" && itemName.Text != "")
            {
                

                var i = CartdataGridView.Rows.Add();
                CartdataGridView.Rows[i].Cells[0].Value = itemName.Text;
                CartdataGridView.Rows[i].Cells[1].Value = price.Text;
                CartdataGridView.Rows[i].Cells[2].Value = quantityUpDown.Text;
                CartdataGridView.Rows[i].Cells[3].Value = Convert.ToInt32(quantityUpDown.Value) * Convert.ToInt32(itemDetail[0].Price);

                Gtotal = Gtotal + Convert.ToInt32(total.Text);
                GrandTotal.Text = Gtotal.ToString() + " TK";
                itemName.Text= "";
                price.Text = "";
                quantityUpDown.Text = "1";
                total.Text = "";
            }
            else
            {
                MessageBox.Show("Select Item First", "Alert");
            }

        }
        private void CartdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CartdataGridView.Rows.RemoveAt(this.CartdataGridView.SelectedRows[0].Index);
                Console.WriteLine(removedValue.ToString());
                Gtotal = Gtotal - removedValue;
                GrandTotal.Text = Gtotal.ToString() + " TK";
            }
            catch { }
        }

        private void CartdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removedValue = int.Parse(CartdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + GrandTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(CartdataGridView);

            CartdataGridView.Rows.Clear();
            Gtotal = 0;
            GrandTotal.Text = Gtotal.ToString() + " TK";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderClass orderClass = new OrderClass();
            orderClass.Name = itemName.Text;
            getItemList();
            orderClass.Quantity = int.Parse(quantityUpDown.Value.ToString());
            orderClass.Price = Gtotal;
            orderClass.UserName = LoginPage.labelName;
            orderClass.SaleDate = DateTime.Now.GetDateTimeFormats('d')[0];

            newAddItemGateway.saveOrders(orderClass);
            MessageBox.Show("Order Saved to Server");

        }

        public void getItemList()
        {
            int i;
            List<string> myItemList = new List<string>();

            for (i = 0; i < CartdataGridView.Rows.Count; i++)
            {       
                myItemList.Add(Convert.ToString(CartdataGridView.Rows[i].Cells[0].Value));
            }
            Console.WriteLine("here " + myItemList.ToString());
        }

    }
}
