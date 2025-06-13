using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            products.Show();
        }

        private void SaleBtn_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
        }

    }
}
