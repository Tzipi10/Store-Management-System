namespace UI
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            productsTitle = new Label();
            customerDgv = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            tabCustomers = new TabControl();
            addCustomer = new TabPage();
            addTypeCb = new ComboBox();
            addCustomerBtn = new Button();
            addPhoneTxt = new TextBox();
            addIdTxt = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            addAddressTxt = new TextBox();
            addNameTxt = new TextBox();
            label4 = new Label();
            updateCustomer = new TabPage();
            idToUpdateCb = new ComboBox();
            updateBtn = new Button();
            phoneTxtB = new TextBox();
            label8 = new Label();
            addressTxtB = new TextBox();
            label9 = new Label();
            nameTxtB = new TextBox();
            label7 = new Label();
            label10 = new Label();
            idTxtB = new TextBox();
            label11 = new Label();
            delete = new TabPage();
            idToDeleteCb = new ComboBox();
            deleteCustomerBtn = new Button();
            label13 = new Label();
            label1 = new Label();
            findCustomerTxt = new TextBox();
            errorProviderCustomers = new ErrorProvider(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)customerDgv).BeginInit();
            tabCustomers.SuspendLayout();
            addCustomer.SuspendLayout();
            updateCustomer.SuspendLayout();
            delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCustomers).BeginInit();
            SuspendLayout();
            // 
            // productsTitle
            // 
            productsTitle.AutoSize = true;
            productsTitle.BackColor = SystemColors.Control;
            productsTitle.Cursor = Cursors.No;
            productsTitle.FlatStyle = FlatStyle.Popup;
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsTitle.ForeColor = Color.PowderBlue;
            productsTitle.Location = new Point(513, 19);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(235, 81);
            productsTitle.TabIndex = 0;
            productsTitle.Text = "לקוחות";
            // 
            // customerDgv
            // 
            customerDgv.BackgroundColor = SystemColors.Control;
            customerDgv.BorderStyle = BorderStyle.None;
            customerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDgv.Columns.AddRange(new DataGridViewColumn[] { id, name, address, phone });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            customerDgv.DefaultCellStyle = dataGridViewCellStyle1;
            customerDgv.GridColor = SystemColors.Control;
            customerDgv.Location = new Point(709, 185);
            customerDgv.Margin = new Padding(3, 4, 3, 4);
            customerDgv.Name = "customerDgv";
            customerDgv.ReadOnly = true;
            customerDgv.RightToLeft = RightToLeft.Yes;
            customerDgv.RowHeadersWidth = 51;
            customerDgv.Size = new Size(472, 587);
            customerDgv.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ת\"ז";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 120;
            // 
            // address
            // 
            address.HeaderText = "כתובת";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 130;
            // 
            // phone
            // 
            phone.HeaderText = "טלפון";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            phone.Width = 120;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(addCustomer);
            tabCustomers.Controls.Add(updateCustomer);
            tabCustomers.Controls.Add(delete);
            tabCustomers.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCustomers.Location = new Point(81, 185);
            tabCustomers.Margin = new Padding(3, 4, 3, 4);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.RightToLeft = RightToLeft.Yes;
            tabCustomers.RightToLeftLayout = true;
            tabCustomers.SelectedIndex = 0;
            tabCustomers.Size = new Size(563, 587);
            tabCustomers.TabIndex = 2;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(addTypeCb);
            addCustomer.Controls.Add(addCustomerBtn);
            addCustomer.Controls.Add(addPhoneTxt);
            addCustomer.Controls.Add(addIdTxt);
            addCustomer.Controls.Add(label2);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(label3);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(addAddressTxt);
            addCustomer.Controls.Add(addNameTxt);
            addCustomer.Controls.Add(label4);
            addCustomer.Location = new Point(4, 40);
            addCustomer.Margin = new Padding(3, 4, 3, 4);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 4, 3, 4);
            addCustomer.Size = new Size(555, 543);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // addTypeCb
            // 
            addTypeCb.FormattingEnabled = true;
            addTypeCb.Location = new Point(161, 333);
            addTypeCb.Margin = new Padding(3, 4, 3, 4);
            addTypeCb.Name = "addTypeCb";
            addTypeCb.Size = new Size(174, 39);
            addTypeCb.TabIndex = 23;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCustomerBtn.Location = new Point(215, 411);
            addCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(177, 56);
            addCustomerBtn.TabIndex = 3;
            addCustomerBtn.Text = "הוספה";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // addPhoneTxt
            // 
            addPhoneTxt.Location = new Point(161, 273);
            addPhoneTxt.Margin = new Padding(3, 4, 3, 4);
            addPhoneTxt.Name = "addPhoneTxt";
            addPhoneTxt.Size = new Size(174, 38);
            addPhoneTxt.TabIndex = 19;
            // 
            // addIdTxt
            // 
            addIdTxt.Location = new Point(161, 93);
            addIdTxt.Margin = new Padding(3, 4, 3, 4);
            addIdTxt.Name = "addIdTxt";
            addIdTxt.Size = new Size(174, 38);
            addIdTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(354, 336);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 14;
            label2.Text = "סוג לקוח";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(399, 92);
            label6.Name = "label6";
            label6.Size = new Size(42, 28);
            label6.TabIndex = 18;
            label6.Text = "ת\"ז";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(381, 275);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 15;
            label3.Text = "טלפון";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(399, 153);
            label5.Name = "label5";
            label5.Size = new Size(42, 28);
            label5.TabIndex = 17;
            label5.Text = "שם";
            // 
            // addAddressTxt
            // 
            addAddressTxt.Location = new Point(161, 213);
            addAddressTxt.Margin = new Padding(3, 4, 3, 4);
            addAddressTxt.Name = "addAddressTxt";
            addAddressTxt.Size = new Size(174, 38);
            addAddressTxt.TabIndex = 20;
            // 
            // addNameTxt
            // 
            addNameTxt.Location = new Point(161, 153);
            addNameTxt.Margin = new Padding(3, 4, 3, 4);
            addNameTxt.Name = "addNameTxt";
            addNameTxt.Size = new Size(174, 38);
            addNameTxt.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(373, 213);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 16;
            label4.Text = "כתובת";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(idToUpdateCb);
            updateCustomer.Controls.Add(updateBtn);
            updateCustomer.Controls.Add(phoneTxtB);
            updateCustomer.Controls.Add(label8);
            updateCustomer.Controls.Add(addressTxtB);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Controls.Add(nameTxtB);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Controls.Add(label10);
            updateCustomer.Controls.Add(idTxtB);
            updateCustomer.Controls.Add(label11);
            updateCustomer.Location = new Point(4, 40);
            updateCustomer.Margin = new Padding(3, 4, 3, 4);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3, 4, 3, 4);
            updateCustomer.Size = new Size(555, 543);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // idToUpdateCb
            // 
            idToUpdateCb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idToUpdateCb.FormattingEnabled = true;
            idToUpdateCb.Location = new Point(218, 83);
            idToUpdateCb.Margin = new Padding(3, 4, 3, 4);
            idToUpdateCb.Name = "idToUpdateCb";
            idToUpdateCb.Size = new Size(177, 39);
            idToUpdateCb.TabIndex = 15;
            idToUpdateCb.SelectedValueChanged += idToUpdateCb_SelectedValueChanged_1;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(221, 412);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(177, 56);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "עדכון";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // phoneTxtB
            // 
            phoneTxtB.Location = new Point(179, 327);
            phoneTxtB.Margin = new Padding(3, 4, 3, 4);
            phoneTxtB.Name = "phoneTxtB";
            phoneTxtB.Size = new Size(138, 38);
            phoneTxtB.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(362, 325);
            label8.Name = "label8";
            label8.Size = new Size(60, 28);
            label8.TabIndex = 5;
            label8.Text = "טלפון";
            // 
            // addressTxtB
            // 
            addressTxtB.Location = new Point(179, 267);
            addressTxtB.Margin = new Padding(3, 4, 3, 4);
            addressTxtB.Name = "addressTxtB";
            addressTxtB.Size = new Size(138, 38);
            addressTxtB.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(353, 267);
            label9.Name = "label9";
            label9.Size = new Size(69, 28);
            label9.TabIndex = 6;
            label9.Text = "כתובת";
            // 
            // nameTxtB
            // 
            nameTxtB.Location = new Point(179, 207);
            nameTxtB.Margin = new Padding(3, 4, 3, 4);
            nameTxtB.Name = "nameTxtB";
            nameTxtB.Size = new Size(138, 38);
            nameTxtB.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(215, 39);
            label7.Name = "label7";
            label7.Size = new Size(183, 31);
            label7.TabIndex = 7;
            label7.Text = "בחר לקוח לעדכון";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(379, 205);
            label10.Name = "label10";
            label10.Size = new Size(42, 28);
            label10.TabIndex = 7;
            label10.Text = "שם";
            // 
            // idTxtB
            // 
            idTxtB.BackColor = SystemColors.Control;
            idTxtB.BorderStyle = BorderStyle.None;
            idTxtB.Location = new Point(179, 147);
            idTxtB.Margin = new Padding(3, 4, 3, 4);
            idTxtB.Name = "idTxtB";
            idTxtB.ReadOnly = true;
            idTxtB.Size = new Size(138, 31);
            idTxtB.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(379, 147);
            label11.Name = "label11";
            label11.Size = new Size(42, 28);
            label11.TabIndex = 8;
            label11.Text = "ת\"ז";
            // 
            // delete
            // 
            delete.Controls.Add(idToDeleteCb);
            delete.Controls.Add(deleteCustomerBtn);
            delete.Controls.Add(label13);
            delete.Location = new Point(4, 40);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 4, 3, 4);
            delete.Size = new Size(555, 543);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // idToDeleteCb
            // 
            idToDeleteCb.Font = new Font("Segoe UI", 11F);
            idToDeleteCb.FormattingEnabled = true;
            idToDeleteCb.Location = new Point(195, 219);
            idToDeleteCb.Margin = new Padding(3, 4, 3, 4);
            idToDeleteCb.Name = "idToDeleteCb";
            idToDeleteCb.Size = new Size(198, 33);
            idToDeleteCb.TabIndex = 5;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteCustomerBtn.Location = new Point(229, 361);
            deleteCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new Size(133, 61);
            deleteCustomerBtn.TabIndex = 4;
            deleteCustomerBtn.Text = "מחיקה";
            deleteCustomerBtn.UseVisualStyleBackColor = true;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(205, 141);
            label13.Name = "label13";
            label13.Size = new Size(173, 38);
            label13.TabIndex = 3;
            label13.Text = "מחיקת לקוח";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(1073, 117);
            label1.Name = "label1";
            label1.Size = new Size(87, 37);
            label1.TabIndex = 3;
            label1.Text = "חיפוש";
            // 
            // findCustomerTxt
            // 
            findCustomerTxt.Font = new Font("Segoe UI", 11F);
            findCustomerTxt.Location = new Point(886, 123);
            findCustomerTxt.Margin = new Padding(3, 4, 3, 4);
            findCustomerTxt.Name = "findCustomerTxt";
            findCustomerTxt.RightToLeft = RightToLeft.Yes;
            findCustomerTxt.Size = new Size(163, 32);
            findCustomerTxt.TabIndex = 4;
            findCustomerTxt.TextChanged += findCustomerTxt_TextChanged;
            findCustomerTxt.Enter += findCustomerTxt_Enter;
            findCustomerTxt.Leave += findCustomerTxt_Leave;
            // 
            // errorProviderCustomers
            // 
            errorProviderCustomers.ContainerControl = this;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(86, 35);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 56);
            button1.TabIndex = 5;
            button1.Text = "חזרה";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 856);
            Controls.Add(button1);
            Controls.Add(findCustomerTxt);
            Controls.Add(label1);
            Controls.Add(tabCustomers);
            Controls.Add(customerDgv);
            Controls.Add(productsTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)customerDgv).EndInit();
            tabCustomers.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productsTitle;
        private DataGridView customerDgv;
        private TabControl tabCustomers;
        private TabPage addCustomer;
        private TabPage updateCustomer;
        private Label label1;
        private TextBox findCustomerTxt;
        private TabPage delete;
        private Button addCustomerBtn;
        private Button updateBtn;
        private TextBox phoneTxtB;
        private Label label8;
        private TextBox addressTxtB;
        private Label label9;
        private TextBox nameTxtB;
        private Label label10;
        private TextBox idTxtB;
        private Label label11;
        private Label label13;
        private Button deleteCustomerBtn;
        private TextBox addPhoneTxt;
        private TextBox addIdTxt;
        private Label label6;
        private Label label3;
        private Label label5;
        private TextBox addAddressTxt;
        private TextBox addNameTxt;
        private Label label4;
        private ComboBox idToDeleteCb;
        private ComboBox idToUpdateCb;
        private Label label7;
        private ComboBox addTypeCb;
        private Label label2;
        private ErrorProvider errorProviderCustomers;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private Button button1;
    }
}