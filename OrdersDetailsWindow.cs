using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEditor
{
    public partial class OrdersDetailsWindow : Form
    {
        int orderId;
        public OrdersDetailsWindow(int id)
        {
            orderId = id;
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validate())
                MessageBox.Show("Cannot validate this record");

            try
            {
                ordersBindingSource.EndEdit();
                order_DetailsBindingSource.EndEdit();
                Console.WriteLine("Orders upated rows: {0}", tableAdapterManager.OrdersTableAdapter.Update(nwindDataSet.Orders));
                Console.WriteLine("Orders details upated rows: {0}", tableAdapterManager.Order_DetailsTableAdapter.Update(nwindDataSet.Order_Details));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrdersDetailsWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
            // TODO: This line of code loads data into the 'nwindDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.nwindDataSet.Shippers);
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            // TODO: This line of code loads data into the 'nwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.FillByOrderId(this.nwindDataSet.Order_Details, orderId);
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.FillByOrderId(this.nwindDataSet.Orders, orderId);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                order_DetailsBindingSource.EndEdit();
            }
            catch (Exception)
            {
                order_DetailsBindingSource.CancelEdit();
            }

        }
    }
}
