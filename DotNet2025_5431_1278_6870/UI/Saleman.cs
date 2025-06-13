using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;

namespace UI
{
    public partial class Saleman : Form
    {
        public static IBl s_bl = Factory.Get();
        public static List<BO.Product> products;
        public const string PlaceholderText = "הכנס שם מוצר";

        public Saleman()
        {
            InitializeComponent();
            searchTb.Text = PlaceholderText;
            searchTb.ForeColor = Color.Gray;
            initialProductsList();
            updateLists();
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            CustomerDetail customerDetail = new CustomerDetail();
            customerDetail.Show();
            this.Close();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            products = s_bl.Product.ReadAll().Where(p => p.ProductName.Contains(searchTb.Text)).ToList()!;
            productsDgv.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productsDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }

        private void initialProductsList()
        {
            products = s_bl.Product.ReadAll();
        }
        private void updateLists()
        {
            productsDgv.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productsDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }

        private void searchTb_Enter(object sender, EventArgs e)
        {
            if (searchTb.Text == PlaceholderText)
            {
                searchTb.Text = "";
                searchTb.ForeColor = Color.Black;
            }
        }

        private void searchTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTb.Text))
            {
                searchTb.Text = PlaceholderText;
                searchTb.ForeColor = Color.Gray;
                initialProductsList();
                updateLists();
            }
        }
    }
}
