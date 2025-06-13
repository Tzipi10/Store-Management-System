using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;


namespace UI
{
    public partial class CustomerDetail : Form
    {
        BO.Order order;

        public CustomerDetail()
        {
            InitializeComponent();

            preferance.DataSource = Enum.GetValues(typeof(BO.CustomerPreference));
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool isValid = true;

            if (preferance.SelectedItem == null)
            {
                errorProvider1.SetError(preferance, "יש לבחור העדפה");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(idTxb.Text) || !int.TryParse(idTxb.Text, out int customerId))
            {
                errorProvider1.SetError(idTxb, "יש להזין מזהה לקוח תקין");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(nameTxb.Text))
            {
                errorProvider1.SetError(nameTxb, "יש להזין שם לקוח");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addresTxb.Text))
            {
                errorProvider1.SetError(addresTxb, "יש להזין כתובת");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(phoneTxb.Text))
            {
                errorProvider1.SetError(phoneTxb, "יש להזין טלפון");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("יש למלא את השדות לפני ההמשך", "שגיאות", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            order = new BO.Order((BO.CustomerPreference)preferance.SelectedItem!);
            Customer customer = new Customer(int.Parse(idTxb.Text), nameTxb.Text, addresTxb.Text, phoneTxb.Text);

            CashRegister cashRegister = new CashRegister(order);
            cashRegister.Show();
            this.Close();
        }

    }
}
