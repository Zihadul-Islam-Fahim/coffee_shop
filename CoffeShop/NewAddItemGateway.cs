using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeShop
{
    public class NewAddItemGateway
    {
        DBConnector connector = null;
        SqlConnection connection = null;
        NewAddItemClass newAddItemClass = null;
        List<NewAddItemClass> itemList = null;


        public NewAddItemGateway()
        {
            connector = new DBConnector();
            connection = connector.Connection;
        }


        public void InsertIntoItemsTable(NewAddItemClass newAddItemClass)
        {
            connection.Open();
            string insertString = "INSERT INTO itemsTable VALUES('" + newAddItemClass.Category + "','" + newAddItemClass.ItemName + "','" + newAddItemClass.Price + "')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<NewAddItemClass> RetrieveritemList()
        {
            connection.Open();
            string queryString = "SELECT * FROM itemsTable";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            itemList = new List<NewAddItemClass>();

            while (dataReader.Read())
            {
                newAddItemClass = new NewAddItemClass();
                newAddItemClass.Category = dataReader["Category"].ToString();
                newAddItemClass.ItemName = dataReader["Item_Name"].ToString();
                newAddItemClass.Price = dataReader["Price"].ToString();


                itemList.Add(newAddItemClass);
            }

            connection.Close();
            return itemList;
        }

        public void removeItem(string name)
        {
            connection.Open();
            string insertString = "delete from itemsTable where Item_Name = " + "'" + name + "'";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void updateItem(string price, string name)
        {
            connection.Open();
            string insertString = " update itemsTable set Price = " + price + " where Item_Name = " + "'" + name + "'";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }



        public List<NewAddItemClass> RetrieveContent()
        {
            connection.Open();


            string queryString = "SELECT distinct Category FROM itemsTable";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            itemList = new List<NewAddItemClass>();

            while (dataReader.Read())
            {
                newAddItemClass = new NewAddItemClass();
                newAddItemClass.Category = dataReader["Category"].ToString();


                itemList.Add(newAddItemClass);
            }

            connection.Close();
            return itemList;
        }

        public List<NewAddItemClass> RetrieveCategorysItems(string category)
        {
            connection.Open();

            string queryString = "select distinct Item_Name from itemsTable where Category = " + "'" + category + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            itemList = new List<NewAddItemClass>();

            while (dataReader.Read())
            {
                newAddItemClass = new NewAddItemClass();

                newAddItemClass.ItemName = dataReader["Item_Name"].ToString();

                itemList.Add(newAddItemClass);
            }

            connection.Close();
            return itemList;
        }

        public List<NewAddItemClass> RetrieveDetaisItem(string itemName)
        {
            connection.Open();
            string queryString = "SELECT distinct * FROM itemsTable where Item_Name = " + "'" + itemName + "'";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            itemList = new List<NewAddItemClass>();

            while (dataReader.Read())
            {
                newAddItemClass = new NewAddItemClass();
                newAddItemClass.Category = dataReader["Category"].ToString();
                newAddItemClass.ItemName = dataReader["Item_Name"].ToString();
                newAddItemClass.Price = dataReader["Price"].ToString();


                itemList.Add(newAddItemClass);
            }

            connection.Close();
            return itemList;
        }

        public void saveOrders(OrderClass orderClass)
        {
            connection.Open();
            string insertString = "INSERT INTO Orders VALUES('" + orderClass.Name + "','" + orderClass.Quantity + "','" + orderClass.Price + "','" + orderClass.UserName + "','" + orderClass.SaleDate + "')";
            SqlCommand command = new SqlCommand(insertString, connection);
            command.ExecuteNonQuery();

            connection.Close();

        }

        public string getSale(String query)
        {
            connection.Open();
            string insertString = query;
            string p = "0";
            SqlCommand command = new SqlCommand(insertString, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                p = dataReader["total"].ToString();
            }
            connection.Close();
            if (p == null || p == "")
            {
                return "0";
            }
            else
            {
                return p;
            }
        }
    }
}
