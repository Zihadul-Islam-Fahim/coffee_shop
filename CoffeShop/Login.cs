using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CoffeShop.AllUserControls;

namespace CoffeShop
{

    public partial class LoginPage : Form

    {
        public static string labelName = "";
        public static string labelEmail = "";

        bool isMatched = false;

        RegistrationGateway registrationGateway;

        List<RegistrationClass> registrationList = null;

        string usernameText = "";
        string passwordText = "";

        void Navigate()

        {
            if (isMatched == true)
            {
                this.Hide();
                HomePage homepage = new HomePage("user");
                homepage.Show();


            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string date = DateTime.Now.GetDateTimeFormats('d')[0];
            Console.WriteLine(date);
            usernameText = usernameTextbox.Text;
            passwordText = passwordTextbox.Text;

            registrationList = new List<RegistrationClass>();
            registrationGateway = new RegistrationGateway();
            registrationList = registrationGateway.RetrieverRegistrationClassFromRegistrationTable();



            if (usernameText == "")
            {
                MessageBox.Show("Enter username");
            }
            else if (passwordText == "")
            {
                MessageBox.Show("Enter Password");
            }
            else
            {

                for (int i = 0; i < registrationList.Count; i++)
                {
                    if (registrationList[i].Username == usernameText && registrationList[i].Password == passwordText)
                    {

                        isMatched = true;
                        labelName = registrationList[i].Firstname + " " + registrationList[i].LastName;
                        labelEmail = registrationList[i].Username;

                        break;
                    }
                    else
                    {
                        isMatched = false;

                    }
                }
                Navigate();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var regForm = new registration();
            regForm.ShowDialog();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin admin = new AdminLogin();     
            admin.Show();

        }

    }
}
