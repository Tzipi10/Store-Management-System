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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace UI
{
    public partial class CashRegister : Form
    {
        static readonly IBl s_bl = Factory.Get();

        List<BO.Product> products = new List<BO.Product>();
        DataGridView productTbl;
        BO.Order order;
        List<BO.ProductInOrder> productInOrder = new List<BO.ProductInOrder>();
        ProductInOrder currentProduct;
        public CashRegister(BO.Order order)
        {
            InitializeComponent();
            this.order = order;
            productInOrder = order.ProductsInOrder;

            productInOrderLv.View = View.Details;
            productInOrderLv.Columns.Add("Product ID", 100);
            productInOrderLv.Columns.Add("Product Name", 150);
            productInOrderLv.Columns.Add("Price", 100);
            productInOrderLv.Columns.Add("Quantity", 100);

            products = s_bl.Product.ReadAll();
            productTbl = this.dataGridView1;

            foreach (BO.Product product in products)
            {
                productTbl.Rows.Add(product.ProductName, product.Price, product.Category, product.ProductCode);
            }

            foreach (BO.ProductInOrder p in productInOrder)

            {
                ListViewItem item = new ListViewItem(p.ProductName.ToString(), int.Parse(p.Price.ToString()));
                //,p.CountInOrder
                productInOrderLv.Items.Add(item);
            }
            productInOrderLv.View = View.List;

            searchTb.TextChanged += new EventHandler(search_TextChanged);
            productTbl.CellDoubleClick += (s, e) => addProductToOrder(s, e);
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            products = s_bl.Product.ReadAll(p => p.ProductName.Contains(searchTb.Text));
            productTbl.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productTbl.Rows.Add(product.ProductName, product.Price, product.Category, product.ProductCode);
            }
        }
        private void showProductsInOrder()
        {
            productInOrderLv.Items.Clear();
            foreach (BO.ProductInOrder p in productInOrder)
            {
                ListViewItem item = new ListViewItem(p.ProductId.ToString());
                item.SubItems.Add(p.ProductName);
                item.SubItems.Add(p.Price.ToString());
                item.SubItems.Add(p.Quantity.ToString());
                productInOrderLv.Items.Add(item);
            }
        }
   
        private void addProductToOrder(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)productTbl.Rows[e.RowIndex].Cells[3].Value;
            s_bl.Order.AddProductToOrder(order, id, 1);
            productInOrder = order.ProductsInOrder;

            if (productInOrderLv.View != View.Details)
            {
                productInOrderLv.View = View.Details;
            }

            showProductsInOrder();
            changeTotalPrice();
        }
        private void changeTotalPrice()
        {
            totalPrice.Text = order.TotalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // acount.Visible = true;
            //להוסיף קוד של חשבונית ופרוט המוצרים וההזמנות
            acountDetailPnl.Visible = true;

            productsAcount.Text = order.ProductsInOrder.ToList().ToString();
            s_bl.Order.DoOrder(order);
            //PrintDgv(productInOrderLv);
            
            //this.Close();
        }

        private void productInOrderLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productInOrderLv.SelectedItems.Count > 0)
            {
                var r = productInOrderLv.SelectedItems[0].SubItems[3].Text;
                count.Value = int.Parse(r);
            }
            else
            {
            }
        }


        private void count_ValueChanged(object sender, EventArgs e)
        {
            if (productInOrderLv.SelectedItems.Count == 0)
            {
                MessageBox.Show("!בחר מוצר");
                count.Value = 1;
            }
            else
            {
                int num = (int)count.Value;
                int id = int.Parse(productInOrderLv.SelectedItems[0].Text);
                productInOrderLv.SelectedItems[0].SubItems[3].Text = num.ToString();

                s_bl.Order.AddProductToOrder(order, id, num);
                Console.WriteLine(order);
                changeTotalPrice();
            }
        }

        private void deletProductFromOrderBtn_Click(object sender, EventArgs e)
        {
            if (productInOrderLv.SelectedItems.Count == 0)
            {
                MessageBox.Show("!בחר מוצר");
                count.Value = 1;
            }
            int id = int.Parse(productInOrderLv.SelectedItems[0].Text);
            s_bl.Order.DeleteProductFromOrder(order, id);
            showProductsInOrder();
            changeTotalPrice();
        }

//        private void PrintDgv(System.Windows.Forms.ListView dgv)
//        {
//            var strB = new StringBuilder();

//            strB.Append(@"<html dir='rtl'><head><style>
//        table {
//            border-collapse: collapse;
//        }
//        td {
//            border: 1px solid black;
//        }
 
//</style></head><body><table><thead><tr>");

//            foreach (DataGridViewColumn col in dgv.Columns)
//                if (col.Visible)
//                {
//                    strB.Append("<th>");
//                    strB.Append(col.HeaderText);
//                    strB.Append("</th>");
//                }

//            strB.Append("</tr></thead>");

//            bool odd = true;
//            foreach (DataGridViewRow row in dgv.Items)
//            {
//                strB.Append("<tr>");
//                foreach (DataGridViewCell cell in row.Cells)
//                {
//                    strB.Append("<td>");
//                    strB.Append(cell.Value);
//                    strB.Append("</td>");
//                }
//                strB.Append("</tr>");
//            }


//            strB.Append("</table></body></html>");

//            //var html = strB.ToString();
//            //File.WriteAllText(@"d:\temp.html", html);

//            var webBrowser1 = new WebBrowser();
//            webBrowser1.Visible = false;
//            webBrowser1.Parent = this;
//            webBrowser1.DocumentText = strB.ToString();

//            webBrowser1.DocumentCompleted += (s, e) => webBrowser1.ShowPrintPreviewDialog();
//        }


    }
}
