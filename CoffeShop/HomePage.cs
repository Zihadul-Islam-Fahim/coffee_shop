using CoffeShop.AllUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class HomePage : Form
    {
        NewAddItemGateway gateway = new NewAddItemGateway();
        public string today_Sale = "0";
        public string total_Sale = "0";
        public string currrentUser = "";
        public void getTotalSell()
        {

        }

        public HomePage(String user)
        {
            InitializeComponent();
            if (user == "user")
            {
                currrentUser = "user";
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
                todaySell.Hide();
                totalSale.Hide();
                adminLabel.Hide();

            }
            if (user == "admin")
            {
                currrentUser = "admin";
            }
        }

        public HomePage()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (currrentUser == "user")
            {
                uC_welcome1.Visible = true;
                uC_additems1.Visible = false;
                uC_UpdateItem1.Visible = false;
                uC_RemoveItem1.Visible = false;
            }
            else
            {
                uC_welcome1.Visible = false;
                uC_additems1.Visible = true;
                uC_UpdateItem1.Visible = false;
                uC_RemoveItem1.Visible = false;
                nameLabel.Hide();
                emailLabel.Hide();

            }
            nameLabel.Text = LoginPage.labelName;
            emailLabel.Text = LoginPage.labelEmail;


            string query = $"SELECT SUM(Item_Price) as total from orders where Sale_time ='{DateTime.Now.GetDateTimeFormats('d')[0].ToString()}';";
            Console.WriteLine(query);
            today_Sale = gateway.getSale(query);
            total_Sale = gateway.getSale("SELECT SUM(Item_Price) as total from orders ;");
            todaySell.Text = todaySell.Text + " : " + today_Sale.ToString();
            totalSale.Text = totalSale.Text + " : " + total_Sale.ToString();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_additems1.Visible = true;
            uC_additems1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItem1.Visible = true;
            uC_UpdateItem1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            UC_RemoveItem uC_RemoveItem = new UC_RemoveItem();
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();

        }

        private void uC_UpdateItem1_Load(object sender, EventArgs e)
        {

        }

        private void uC_remove1_Load(object sender, EventArgs e)
        {

        }

        private void btnPleaseOrder_Click(object sender, EventArgs e)
        {
            uC_welcome1.Visible = true;
            uC_welcome1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
