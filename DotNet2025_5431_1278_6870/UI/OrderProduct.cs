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
using BO;

namespace UI
{
    public partial class OrderProduct : Form
    {
        public static IBl s_bl = Factory.Get();
        public OrderProduct()
        {
            InitializeComponent();

            categoryCmb.DataSource = Enum.GetValues(typeof(BO.Categories));

            List<BO.Product> products = s_bl.Product.ReadAll();
            products = products.Where(p => p.Quantity <= 5).ToList();
            foreach (var product in products)
            {
                productsDGV.Rows.Add( product.ProductCode,product.ProductName, product.Quantity,product.Price, product.Category );
            }

        }

        private void orderProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxt.Text.Length == 0 || priceTxt.Text.Length == 0 || amountTxt.Text.Length == 0)
                    throw new Exception("יש למלא את כל הפרטים");
                int quantity;
                try
                {
                    quantity = int.Parse(amountTxt.Text);
                }
                catch (Exception)
                {
                    throw new Exception("יש להכניס כמות עם מספר שלם");
                }
                BO.Product product = new BO.Product(0, nameTxt.Text, int.Parse(priceTxt.Text), quantity, (Categories)categoryCmb.SelectedItem);
                s_bl.Product.Create(product);

                nameTxt.Text = "";
                priceTxt.Text = "0";
                amountTxt.Text = "0";

                MessageBox.Show("ההזמנה בוצעה בהצלחה!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void productsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
