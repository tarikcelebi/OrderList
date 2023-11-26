using Microsoft.EntityFrameworkCore;
using OrderList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderList
{
    public partial class AddUpdateOrder : Form
    {
        public AddUpdateOrder()
        {
            InitializeComponent();
        }

        public AddUpdateOrder(Models.Order selectedOrder)
        {
            MessageBox.Show("BU KOD DENEME ICIN EKLENDI");
         
        }

        Order Order;
        NorthwindContext dbContext;
        private void AddUpdateOrder_Load(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();

            if (Order == null)
            {
                NorthwindContext db = new NorthwindContext();
                List<Employee> employees1 = db.Employees.ToList();
                List<Shipper> shippers1 = db.Shippers.ToList();
                cmbEmployees.DataSource = employees1;
                cmbShippers.DataSource = shippers1;

            }
            
           
                List<Employee> employees = dbContext.Employees.ToList();
                List<Shipper> shippers = dbContext.Shippers.ToList();
                cmbEmployees.DataSource = employees;
                cmbShippers.DataSource = shippers;
                //cmbEmployees.SelectedItem = this.Order.Employee.FirstName;
                //cmbShippers.SelectedItem = this.Order.ShipVia.ToString();
            

        }

        private void btnAddorUpdate_Click(object sender, EventArgs e)
        {
            dbContext = new NorthwindContext();
            if (Order != null)
            {
                Order order = dbContext.Orders.FirstOrDefault(order => order.EmployeeId == this.Order.EmployeeId && order.ShipVia == this.Order.ShipVia);
                order.Employee.FirstName = cmbEmployees.Text;
                order.OrderDate= dtpOrderDAte.Value;
                Shipper shipper = (Shipper)dbContext.Orders.Where(s => s.ShipVia == this.Order.ShipVia);
                shipper.CompanyName = txtShipCity.Text;
                if (MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dbContext.Orders.Update(order);
                    dbContext.Shippers.Update(shipper);
                    dbContext.SaveChanges();
                    MessageBox.Show("Kaydedildi!", "Bilgi", MessageBoxButtons.OK);
                    this.Close();
                }

            }
            else
            {
                Order order = new Order();
                Employee employee = new Employee();
                employee.FirstName = cmbEmployees.Text;
                order.OrderDate = dtpOrderDAte.Value;
                Shipper shipper = new Shipper();
                shipper.CompanyName = txtShipCity.Text;
                if (MessageBox.Show("Yeni bir kayıt istediğinize emin misiniz?", "Onay", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dbContext.Orders.Add(order);
                    dbContext.Shippers.Add(shipper);
                    dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                    MessageBox.Show("Kaydedildi!", "Bilgi", MessageBoxButtons.OK);
                    this.Close();
                }


            }
            
        }
    }
}
