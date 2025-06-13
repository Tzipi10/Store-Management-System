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
    public partial class Customers : Form
    {
        static readonly IBl s_bl = Factory.Get();
        List<Customer> customers = new List<Customer>();
        public const string PlaceholderText = "הכנס שם לקוח";

        public Customers()
        {
            InitializeComponent();

            findCustomerTxt.Text = PlaceholderText;
            findCustomerTxt.ForeColor = Color.Gray;
            customers = s_bl.Customer.ReadAll()!;
            updateDgv();
            addTypeCb.DataSource = Enum.GetValues(typeof(CustomerPreference));

            idToUpdateCb.DataSource = customers;
            idToUpdateCb.DisplayMember = "Name";
            idToUpdateCb.ValueMember = "Id";

            idToDeleteCb.DataSource = customers;
            idToDeleteCb.DisplayMember = "Name";
            idToDeleteCb.ValueMember = "Id";
        }


        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            errorProviderCustomers.Clear();

            bool isValid = true;

            // בדיקות שדות
            if (string.IsNullOrWhiteSpace(addIdTxt.Text) || !int.TryParse(addIdTxt.Text, out _))
            {
                errorProviderCustomers.SetError(addIdTxt, "הזן מזהה לקוח תקין");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addNameTxt.Text))
            {
                errorProviderCustomers.SetError(addNameTxt, "הזן שם לקוח");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addAddressTxt.Text))
            {
                errorProviderCustomers.SetError(addAddressTxt, "הזן כתובת לקוח");
                isValid = false;
            }

            if (!IsPhoneNumberValid(addPhoneTxt.Text))
            {
                errorProviderCustomers.SetError(addPhoneTxt, "הזן מספר טלפון תקין");
                isValid = false;
            }

            // אם כל השדות תקינים, המשך להוסיף את הלקוח
            if (isValid)
            {
                try
                {
                    Customer c = new Customer(int.Parse(addIdTxt.Text), addNameTxt.Text, addAddressTxt.Text, addPhoneTxt.Text);
                    s_bl.Customer.Create(c);
                    string name = c.Name;
                    customers = s_bl.Customer.ReadAll()!;
                    idToUpdateCb.DataSource = customers;
                    idToDeleteCb.DataSource = customers;
                    updateDgv();
                    MessageBox.Show($"הלקוח '{name}' נוסף בהצלחה");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void updateBtn_Click(object sender, EventArgs e)
        {
            errorProviderCustomers.Clear();
            bool isValid = true;

            // בדיקות שדות
            //if (string.IsNullOrWhiteSpace(idTxtB.Text) || !int.TryParse(idTxtB.Text, out _))
            //{
            //    errorProviderCustomers.SetError(idTxtB, "הזן מזהה לקוח תקין");
            //    isValid = false;
            //}

            if (string.IsNullOrWhiteSpace(nameTxtB.Text))
            {
                errorProviderCustomers.SetError(nameTxtB, "הזן שם לקוח");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addressTxtB.Text))
            {
                errorProviderCustomers.SetError(addressTxtB, "הזן כתובת לקוח");
                isValid = false;
            }

            if (!IsPhoneNumberValid(phoneTxtB.Text))
            {
                errorProviderCustomers.SetError(phoneTxtB, "הזן מספר טלפון תקין");
                isValid = false;
            }

            if (isValid)
            {
                try
                {
                    Customer? selectedCustomer = (Customer)idToUpdateCb.SelectedItem!;
                    Customer c = new(selectedCustomer.Id, nameTxtB.Text, addressTxtB.Text, phoneTxtB.Text);
                    string name = c.Name;
                    s_bl!.Customer.Update(c);
                    customers = s_bl.Customer.ReadAll()!;
                    idToUpdateCb.DataSource = customers;
                    updateDgv();
                    MessageBox.Show($"הלקוח '{name}' עודכן בהצלחה");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("האם אתה בטוח?", "מחיקת לקוח", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Customer? customer = (Customer)idToDeleteCb.SelectedItem!;
                    string name = customer.Name;
                    s_bl!.Customer.Delete(customer.Id);
                    customers = s_bl.Customer.ReadAll()!;
                    idToUpdateCb.DataSource = customers;
                    idToDeleteCb.DataSource = customers;
                    updateDgv();
                    MessageBox.Show($"הלקוח '{name}' נמחק בהצלחה");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idToUpdateCb_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (idToUpdateCb.SelectedItem is Customer customer)
            {
                idTxtB.Text = customer.Id.ToString();
                nameTxtB.Text = customer.Name;
                addressTxtB.Text = customer.Address;
                phoneTxtB.Text = customer.PhoneNumber;
            }
            else
            {
                idTxtB.Clear();
                nameTxtB.Clear();
                addressTxtB.Clear();
                phoneTxtB.Clear();
            }
        }

        private void updateDgv()
        {
            customerDgv.Rows.Clear();

            foreach (Customer? customer in customers)
                customerDgv.Rows.Add(customer!.Id, customer.Name, customer.Address, customer.PhoneNumber);

        }

        private void findCustomerTxt_TextChanged(object sender, EventArgs e)
        {
            customers = s_bl.Customer.ReadAll(p => p.Name.Contains(findCustomerTxt.Text))!;
            customerDgv.Rows.Clear();
            updateDgv();
        }

        private void findCustomerTxt_Enter(object sender, EventArgs e)
        {
            if (findCustomerTxt.Text == PlaceholderText)
            {
                findCustomerTxt.Text = "";
                findCustomerTxt.ForeColor = Color.Black;
            }
        }

        private void findCustomerTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findCustomerTxt.Text))
            {
                findCustomerTxt.Text = PlaceholderText;
                findCustomerTxt.ForeColor = Color.Gray;
                updateDgv();
            }
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber)
                || !phoneNumber.All(char.IsDigit)
                || phoneNumber.Length > 10
                || phoneNumber.Length < 9)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
