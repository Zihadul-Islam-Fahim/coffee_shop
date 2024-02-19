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
    public partial class UC_RemoveItem : UserControl
    {
        List<NewAddItemClass> itemList = null;
        NewAddItemGateway newAddItemGateway = new NewAddItemGateway();
        public UC_RemoveItem()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void itemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item ? ", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String name = itemGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                newAddItemGateway.removeItem(name);
                reload();
                MessageBox.Show("" + name + " Deleted Succesfully");
            }
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            reload();
        }
        public void reload()
        {
            itemList = newAddItemGateway.RetrieveritemList();
            itemGridView.DataSource = itemList;
        }


    }
}
