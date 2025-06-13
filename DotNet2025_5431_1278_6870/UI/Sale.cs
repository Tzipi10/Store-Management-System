using BlApi;
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
    public partial class Sale : Form
    {
        public static IBl s_bl = Factory.Get();
        public static List<BO.Sale> sales;
        public const string PlaceholderText = "הכנס שם מוצר למבצע";

        public Sale()
        {
            InitializeComponent();


            findSaleTxt.Text = PlaceholderText;
            findSaleTxt.ForeColor = Color.Gray;
            initialSalesList();
            initialSalesList();
            updateLists(sales);
            codeSaleToUpdateCB.DisplayMember = "SaleCode";
            codeSaleToUpdateCB.ValueMember = "SaleCode";

            saleCodeToDeleteCB.DisplayMember = "SaleCode";
            saleCodeToDeleteCB.ValueMember = "SaleCode";
        }

        private void findSaleTxt_Enter(object sender, EventArgs e)
        {
            if (findSaleTxt.Text == PlaceholderText)
            {
                findSaleTxt.Text = "";
                findSaleTxt.ForeColor = Color.Black;
            }
        }

        private void findSaleTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findSaleTxt.Text))
            {
                findSaleTxt.Text = PlaceholderText;
                findSaleTxt.ForeColor = Color.Gray; // Reset color to gray
                initialSalesList();
                updateLists(sales);
            }
        }

        private void findSaleTxt_TextChanged(object sender, EventArgs e)
        {
            List<BO.Product> products = s_bl.Product.ReadAll().Where(p => p.ProductName.Contains(findSaleTxt.Text)).ToList();
            sales = s_bl.sale.ReadAll(p => products.FirstOrDefault(pr => pr.ProductCode == p.ProductId) != null);
            updateLists(sales);
        }

        private void updateLists(List<BO.Sale> salesL)
        {
            salesDgv.Rows.Clear();
            foreach (BO.Sale sale in salesL)
            {
                salesDgv.Rows.Add(sale.SaleCode, sale.ProductId, sale.QuantityForSale, sale.SalePrice, sale.IsClub, sale.StartSale, sale.EndSale);
            }
            codeSaleToUpdateCB.DataSource = salesL;
            saleCodeToDeleteCB.DataSource = salesL;
        }

        private void initialSalesList()
        {
            sales = s_bl.sale.ReadAll();
        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(addProductIdTxt.Text))
            {
                errorProvider1.SetError(addProductIdTxt, "יש להזין מזהה מוצר");
                isValid = false;
            }

            if (addAmountSaleNUD.Value <= 0)
            {
                errorProvider1.SetError(addAmountSaleNUD, "כמות חייבת להיות גדולה מ-0");
                isValid = false;
            }

            if (addPriceNUD.Value < 0)
            {
                errorProvider1.SetError(addPriceNUD, "מחיר לא יכול להיות שלילי");
                isValid = false;
            }

            if (startSaleDTP.Value >= endSaleDTP.Value)
            {
                errorProvider1.SetError(endSaleDTP, "תאריך סיום חייב להיות לאחר תאריך התחלה");
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    BO.Sale sale = new BO.Sale(0, int.Parse(addProductIdTxt.Text), (int)addAmountSaleNUD.Value, (int)addPriceNUD.Value, isClubCB.Checked, startSaleDTP.Value, endSaleDTP.Value);
                    s_bl.sale.Create(sale);
                    initialSalesList();
                    updateLists(sales);
                    MessageBox.Show("המבצע נוסף בהצלחה!");

                    addProductIdTxt.Text = string.Empty;
                    addAmountSaleNUD.Value = 1;
                    addPriceNUD.Value = 0;
                    isClubCB.Checked = false;
                    startSaleDTP.Value = DateTime.Now;
                    endSaleDTP.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (codeSaleToUpdateCB.SelectedItem == null)
            {
                errorProvider1.SetError(codeSaleToUpdateCB, "יש לבחור מבצע לעדכון");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(productIdTxt.Text))
            {
                errorProvider1.SetError(productIdTxt, "יש להזין מזהה מוצר");
                isValid = false;
            }

            if (amountSaleNUD.Value <= 0)
            {
                errorProvider1.SetError(amountSaleNUD, "כמות חייבת להיות גדולה מ-0");
                isValid = false;
            }

            if (priceNum.Value < 0)
            {
                errorProvider1.SetError(priceNum, "מחיר לא יכול להיות שלילי");
                isValid = false;
            }

            if (startSaleDTP.Value >= EndDate.Value)
            {
                errorProvider1.SetError(EndDate, "תאריך סיום חייב להיות לאחר תאריך התחלה");
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    BO.Sale selectedSale = (BO.Sale)codeSaleToUpdateCB.SelectedItem;
                    BO.Sale sale = new BO.Sale(selectedSale.SaleCode, int.Parse(productIdTxt.Text),
                        (int)amountSaleNUD.Value, (int)priceNum.Value, clubCB.Checked,
                        startSaleDTP.Value, endSaleDTP.Value);
                    s_bl.sale.Update(sale);
                    initialSalesList();
                    updateLists(sales);
                    MessageBox.Show("המבצע עודכן בהצלחה!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void codeSaleToUpdateCB_selectedValueChanged(object sender, EventArgs e)
        {
            if (codeSaleToUpdateCB.SelectedItem is BO.Sale sale)
            {
                productIdTxt.Text = sale.ProductId.ToString();
                amountSaleNUD.Value = sale.QuantityForSale;
                priceNum.Value = (int)sale.SalePrice;//show int, not double
                startDate.Value = sale.StartSale ?? DateTime.Now;
                EndDate.Value = sale.EndSale ?? DateTime.Now;
                clubCB.Checked = sale.IsClub ?? false;
            }
            else
            {
                productIdTxt.Clear();
                amountSaleNUD.Value = 1;
                priceNum.Value = 0;
                startDate.Value = DateTime.Now;
                EndDate.Value = DateTime.Now;
                clubCB.Checked = false;
            }
        }

        private void deleteSaleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale? sale = (BO.Sale)saleCodeToDeleteCB.SelectedItem!;
                s_bl!.sale.Delete(sale.SaleCode);
                sales = s_bl.sale.ReadAll();
                updateLists(sales);
                MessageBox.Show("המבצע נמחק בהצלחה!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
