using BlApi;
using BO;
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
    public partial class Product : Form
    {
        public static IBl s_bl = Factory.Get();
        public static List<BO.Product> products;
        public const string PlaceholderText = "הכנס שם מוצר";

        public Product()
        {
            InitializeComponent();

            findProductTxt.Text = PlaceholderText;
            findProductTxt.ForeColor = Color.Gray;
            initialProductsList();
            updateLists();

            codeProductToUpdateCB.DisplayMember = "ProductName";
            codeProductToUpdateCB.ValueMember = "ProductCode";

            codeProductToDeleteCB.DisplayMember = "ProductName";
            codeProductToDeleteCB.ValueMember = "ProductCode";

            addCategoryComb.DataSource = Enum.GetValues(typeof(BO.Categories));
            saerchCategoryCb.Items.Add("All");
            foreach (var category in Enum.GetValues(typeof(BO.Categories)))
            {
                saerchCategoryCb.Items.Add(category);
            }
            saerchCategoryCb.SelectedIndex = 0;
        }

        private void findProductTxt_Enter(object sender, EventArgs e)
        {
            if (findProductTxt.Text == PlaceholderText)
            {
                findProductTxt.Text = "";
                findProductTxt.ForeColor = Color.Black;
            }
        }

        private void findProductTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findProductTxt.Text))
            {
                findProductTxt.Text = PlaceholderText;
                findProductTxt.ForeColor = Color.Gray;
                initialProductsList();
                updateLists();
            }
        }

        private void updateLists()
        {
            productDgv.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
            codeProductToUpdateCB.DataSource = products;
            codeProductToDeleteCB.DataSource = products;
        }

        private void initialProductsList()
        {
            products = s_bl.Product.ReadAll();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderProduct form = new OrderProduct();
            form.Show();
            this.Close();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product product = new BO.Product(0, addNameTxt.Text, (int)addPriceNUP.Value, (int)addAmountN.Value, (BO.Categories)addCategoryComb.SelectedItem);
                string productName = product.ProductName;

                s_bl.Product.Create(product);
                initialProductsList();
                updateLists();
                MessageBox.Show($"המוצר '{productName}' נוסף בהצלחה");

                addNameTxt.Text = string.Empty;
                addPriceNUP.Value = 0;
                addAmountN.Value = 0;
                addCategoryComb.DataSource = Enum.GetValues(typeof(BO.Categories));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findProductTxt_TextChanged(object sender, EventArgs e)
        {
            string searchText = findProductTxt.Text;
            string selectedCategory = saerchCategoryCb.SelectedItem?.ToString() ?? "All";

            products = s_bl.Product.ReadAll()
                .Where(p => (selectedCategory.Equals("All") || p.Category.ToString().Equals(selectedCategory)) &&
                            p.ProductName.Contains(searchText)).ToList()!;

            productDgv.Rows.Clear();
            foreach (BO.Product product in products)
            {
                productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }

        //private void saerchCategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    FilterProducts();
        //}

        //private void findProductTxt_TextChanged(object sender, EventArgs e)
        //{
        //    FilterProducts();
        //}

        //private void FilterProducts()
        //{
        //    string searchText = findProductTxt.Text;
        //    string selectedCategory = saerchCategoryCb.SelectedItem?.ToString() ?? "All";

        //    products = s_bl.Product.ReadAll()
        //        .Where(p => (selectedCategory.Equals("All") || p.Category.ToString().Equals(selectedCategory)) &&
        //                    (string.IsNullOrEmpty(searchText) || p.ProductName.Contains(searchText)))
        //        .ToList()!;

        //    productDgv.Rows.Clear();
        //    foreach (BO.Product product in products)
        //    {
        //        productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
        //    }
        //}


        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product selectedProduct = (BO.Product)codeProductToUpdateCB.SelectedItem;
                string productName = updateNameTxt.Text;

                BO.Product product = new BO.Product(selectedProduct.ProductCode, updateNameTxt.Text,
                    (int)updatePriceNUD.Value, (int)quantityNUD.Value, (BO.Categories)updateCategoryCmb.SelectedItem);
                s_bl.Product.Update(product);
                initialProductsList();
                updateLists();
                MessageBox.Show($"המוצר '{productName}' עודכן בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codeProductToUpdateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (codeProductToUpdateCB.SelectedItem is BO.Product product)
            {
                updateNameTxt.Text = product.ProductName;
                updatePriceNUD.Value = (decimal)(double)product.Price;//double, but show int
                quantityNUD.Value = (int)product.Quantity;
                //updateCategoryCmb.Items.Clear();
                foreach (var category in Enum.GetValues(typeof(Categories)))
                {
                    updateCategoryCmb.Items.Add(category);
                }

                updateCategoryCmb.SelectedItem = product.Category;
            }
            else
            {
                updateNameTxt.Text = string.Empty;
                updatePriceNUD.Value = 0;//double, but show int
                quantityNUD.Value = 0;
                updateCategoryCmb.DataSource = Enum.GetValues(typeof(BO.Categories));
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product? product = (BO.Product)codeProductToDeleteCB.SelectedItem!;
                string productName = product.ProductName;
                s_bl!.Product.Delete(product.ProductCode);
                products = s_bl.Product.ReadAll()!;
                updateLists();
                MessageBox.Show($"המוצר '{productName}' נמחק בהצלחה");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saerchCategoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (saerchCategoryCb.SelectedIndex == 0)
            {
                initialProductsList();
                updateLists();
            }
            else
            {
                products = s_bl.Product.ReadAll(p => p.Category == (Categories)Enum.Parse(typeof(Categories), saerchCategoryCb.Text))!;
                productDgv.Rows.Clear();
                foreach (BO.Product product in products)
                    productDgv.Rows.Add(product.ProductCode, product.ProductName, product.Quantity, product.Price, product.Category);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
