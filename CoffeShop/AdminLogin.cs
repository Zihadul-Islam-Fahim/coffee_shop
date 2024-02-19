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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminUserName.Text == "admin" && asminPassword.Text == "superadmin")
            {
                HomePage homePage = new HomePage("admin");
                LoginPage loginPage = new LoginPage();
                loginPage.Close();

                homePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password! Try Again!!");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void adminUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs eventArgs)
        {
            Application.Exit();
        }

    }
}
