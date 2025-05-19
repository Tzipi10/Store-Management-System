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
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // יצירת תפריט
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem customersMenu = new ToolStripMenuItem("לקוחות");
            customersMenu.DropDownItems.Add("הוסף", null, AddCustomer_Click);
            customersMenu.DropDownItems.Add("עדכן", null, UpdateCustomer_Click);
            customersMenu.DropDownItems.Add("מחק", null, DeleteCustomer_Click);

            ToolStripMenuItem productsMenu = new ToolStripMenuItem("מוצרים");
            productsMenu.DropDownItems.Add("הוסף", null, AddProduct_Click);
            productsMenu.DropDownItems.Add("עדכן", null, UpdateProduct_Click);
            productsMenu.DropDownItems.Add("מחק", null, DeleteProduct_Click);

            ToolStripMenuItem salesMenu = new ToolStripMenuItem("מבצעים");
            salesMenu.DropDownItems.Add("הוסף", null, AddSale_Click);
            salesMenu.DropDownItems.Add("עדכן", null, UpdateSale_Click);
            salesMenu.DropDownItems.Add("מחק", null, DeleteSale_Click);

            menuStrip.Items.Add(customersMenu);
            menuStrip.Items.Add(productsMenu);
            menuStrip.Items.Add(salesMenu);

            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void DeleteSale_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateSale_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddSale_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
