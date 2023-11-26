using Microsoft.EntityFrameworkCore;
using OrderList.Models;
using System.Windows.Forms;

namespace OrderList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbContext = new NorthwindContext();
        }
        NorthwindContext dbContext;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("gdfhggfhgfhghfgh");


        }

        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex == -1 && lstTransportCompany.SelectedIndex == -1)
            {
                NorthwindContext dbContext = new NorthwindContext();
                List<Order> orders = dbContext.Orders.ToList();
                lstOrders.DataSource = orders;
            }
            if (lstEmployees.SelectedIndex == -1 && lstTransportCompany.SelectedIndex != -1)
            {
                MessageBox.Show("Lütfen bir çalışan seçiniz.");
            }
            if (lstEmployees.SelectedIndex != -1 && lstTransportCompany.SelectedIndex != -1)
            {
                NorthwindContext dbContext = new NorthwindContext();
                Employee selectedEmployee = (Employee)lstEmployees.SelectedItem;
                Shipper selectedShipper = (Shipper)lstTransportCompany.SelectedItem;
                List<Order> orders = dbContext.Orders.Where(order => order.EmployeeId == selectedEmployee.EmployeeId && order.ShipVia == selectedShipper.ShipperId).ToList();
                lstOrders.DataSource = orders;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateOrder addUpdateOrderFrm = new AddUpdateOrder();
            addUpdateOrderFrm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)lstOrders.SelectedItem;
            AddUpdateOrder addUpdateOrderFrm = new AddUpdateOrder(selectedOrder);
            addUpdateOrderFrm.Show();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)lstOrders.SelectedItem;

            if (selectedOrder != null)
            {

                Order orderToDelete = dbContext.Orders.FirstOrDefault(o => o.OrderId == selectedOrder.OrderId);

                if (orderToDelete != null)
                {

                    dbContext.Orders.Remove(orderToDelete);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}