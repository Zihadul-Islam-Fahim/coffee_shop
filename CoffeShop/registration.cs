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
    public partial class registration : Form
    {
        RegistrationGateway registrationGateway;
        RegistrationClass registrationClass = null;


        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {
                MessageBox.Show("First Name Required");
            }
            else if (lastName.Text == "")
            {
                MessageBox.Show("Last Name Required");
            }
            else if (userName.Text == "")
            {
                MessageBox.Show("Username Required");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Password Required");
            }
            else
            {
                registrationClass = new RegistrationClass();
                registrationClass.Firstname = firstName.Text;
                registrationClass.LastName = lastName.Text;
                registrationClass.Username = userName.Text;
                registrationClass.Password = password.Text;

                registrationGateway = new RegistrationGateway();
                registrationGateway.InsertIntoRegistrationTable(registrationClass);
                MessageBox.Show("Account Created Succesfully \n Please Login");
                this.Dispose();
            }

        }

        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
