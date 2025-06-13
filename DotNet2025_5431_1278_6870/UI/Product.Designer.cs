namespace UI
{
    partial class Product
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabProducts = new TabControl();
            addCustomer = new TabPage();
            label2 = new Label();
            label3 = new Label();
            addAmountN = new NumericUpDown();
            label5 = new Label();
            addPriceNUP = new NumericUpDown();
            label6 = new Label();
            addCustomerBtn = new Button();
            addCategoryComb = new ComboBox();
            addNameTxt = new TextBox();
            updateCustomer = new TabPage();
            quantityNUD = new NumericUpDown();
            label10 = new Label();
            codeProductToUpdateCB = new ComboBox();
            updatePriceNUD = new NumericUpDown();
            updateBtn = new Button();
            updateCategoryCmb = new ComboBox();
            updateNameTxt = new TextBox();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            delete = new TabPage();
            codeProductToDeleteCB = new ComboBox();
            deleteProductBtn = new Button();
            label13 = new Label();
            productsTitle = new Label();
            findProductTxt = new TextBox();
            label1 = new Label();
            productDgv = new DataGridView();
            producerCode = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            orderBtn = new Button();
            saerchCategoryCb = new ComboBox();
            back = new Button();
            tabProducts.SuspendLayout();
            addCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNUP).BeginInit();
            updateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updatePriceNUD).BeginInit();
            delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDgv).BeginInit();
            SuspendLayout();
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(addCustomer);
            tabProducts.Controls.Add(updateCustomer);
            tabProducts.Controls.Add(delete);
            tabProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabProducts.Location = new Point(98, 203);
            tabProducts.Margin = new Padding(3, 4, 3, 4);
            tabProducts.Name = "tabProducts";
            tabProducts.RightToLeft = RightToLeft.Yes;
            tabProducts.RightToLeftLayout = true;
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(544, 549);
            tabProducts.TabIndex = 3;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(label2);
            addCustomer.Controls.Add(label3);
            addCustomer.Controls.Add(addAmountN);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(addPriceNUP);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(addCustomerBtn);
            addCustomer.Controls.Add(addCategoryComb);
            addCustomer.Controls.Add(addNameTxt);
            addCustomer.Location = new Point(4, 37);
            addCustomer.Margin = new Padding(3, 4, 3, 4);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 4, 3, 4);
            addCustomer.Size = new Size(536, 508);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(401, 115);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 15;
            label2.Text = "שם";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(389, 285);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 12;
            label3.Text = "מחיר";
            // 
            // addAmountN
            // 
            addAmountN.Location = new Point(154, 227);
            addAmountN.Margin = new Padding(3, 4, 3, 4);
            addAmountN.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            addAmountN.Name = "addAmountN";
            addAmountN.Size = new Size(137, 34);
            addAmountN.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(329, 228);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 14;
            label5.Text = "כמות במלאי";
            // 
            // addPriceNUP
            // 
            addPriceNUP.Location = new Point(154, 283);
            addPriceNUP.Margin = new Padding(3, 4, 3, 4);
            addPriceNUP.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            addPriceNUP.Name = "addPriceNUP";
            addPriceNUP.Size = new Size(137, 34);
            addPriceNUP.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(360, 171);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 13;
            label6.Text = "קטגוריה";
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(190, 353);
            addCustomerBtn.Margin = new Padding(3, 4, 3, 4);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(177, 56);
            addCustomerBtn.TabIndex = 3;
            addCustomerBtn.Text = "הוספה";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // addCategoryComb
            // 
            addCategoryComb.FormattingEnabled = true;
            addCategoryComb.Location = new Point(153, 169);
            addCategoryComb.Margin = new Padding(3, 4, 3, 4);
            addCategoryComb.Name = "addCategoryComb";
            addCategoryComb.Size = new Size(138, 36);
            addCategoryComb.TabIndex = 2;
            // 
            // addNameTxt
            // 
            addNameTxt.Location = new Point(153, 113);
            addNameTxt.Margin = new Padding(3, 4, 3, 4);
            addNameTxt.Name = "addNameTxt";
            addNameTxt.Size = new Size(138, 34);
            addNameTxt.TabIndex = 1;
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(quantityNUD);
            updateCustomer.Controls.Add(label10);
            updateCustomer.Controls.Add(codeProductToUpdateCB);
            updateCustomer.Controls.Add(updatePriceNUD);
            updateCustomer.Controls.Add(updateBtn);
            updateCustomer.Controls.Add(updateCategoryCmb);
            updateCustomer.Controls.Add(updateNameTxt);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(label8);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Location = new Point(4, 37);
            updateCustomer.Margin = new Padding(3, 4, 3, 4);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3, 4, 3, 4);
            updateCustomer.Size = new Size(536, 508);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // quantityNUD
            // 
            quantityNUD.Location = new Point(171, 256);
            quantityNUD.Margin = new Padding(3, 4, 3, 4);
            quantityNUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityNUD.Name = "quantityNUD";
            quantityNUD.Size = new Size(137, 34);
            quantityNUD.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(281, 35);
            label10.Name = "label10";
            label10.Size = new Size(91, 28);
            label10.TabIndex = 31;
            label10.Text = "קוד מוצר";
            // 
            // codeProductToUpdateCB
            // 
            codeProductToUpdateCB.FormattingEnabled = true;
            codeProductToUpdateCB.Location = new Point(239, 67);
            codeProductToUpdateCB.Margin = new Padding(3, 4, 3, 4);
            codeProductToUpdateCB.Name = "codeProductToUpdateCB";
            codeProductToUpdateCB.Size = new Size(138, 36);
            codeProductToUpdateCB.TabIndex = 30;
            codeProductToUpdateCB.SelectedIndexChanged += codeProductToUpdateCB_SelectedIndexChanged;
            // 
            // updatePriceNUD
            // 
            updatePriceNUD.Location = new Point(171, 311);
            updatePriceNUD.Margin = new Padding(3, 4, 3, 4);
            updatePriceNUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            updatePriceNUD.Name = "updatePriceNUD";
            updatePriceNUD.Size = new Size(137, 34);
            updatePriceNUD.TabIndex = 15;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(200, 412);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(177, 56);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "עדכון";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // updateCategoryCmb
            // 
            updateCategoryCmb.FormattingEnabled = true;
            updateCategoryCmb.Location = new Point(170, 196);
            updateCategoryCmb.Margin = new Padding(3, 4, 3, 4);
            updateCategoryCmb.Name = "updateCategoryCmb";
            updateCategoryCmb.Size = new Size(138, 36);
            updateCategoryCmb.TabIndex = 14;
            // 
            // updateNameTxt
            // 
            updateNameTxt.Location = new Point(170, 139);
            updateNameTxt.Margin = new Padding(3, 4, 3, 4);
            updateNameTxt.Name = "updateNameTxt";
            updateNameTxt.Size = new Size(138, 34);
            updateNameTxt.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(382, 148);
            label9.Name = "label9";
            label9.Size = new Size(42, 28);
            label9.TabIndex = 11;
            label9.Text = "שם";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(370, 319);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 8;
            label4.Text = "מחיר";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(310, 261);
            label8.Name = "label8";
            label8.Size = new Size(114, 28);
            label8.TabIndex = 10;
            label8.Text = "כמות במלאי";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(341, 205);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 9;
            label7.Text = "קטגוריה";
            // 
            // delete
            // 
            delete.Controls.Add(codeProductToDeleteCB);
            delete.Controls.Add(deleteProductBtn);
            delete.Controls.Add(label13);
            delete.Location = new Point(4, 37);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 4, 3, 4);
            delete.Size = new Size(536, 508);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // codeProductToDeleteCB
            // 
            codeProductToDeleteCB.FormattingEnabled = true;
            codeProductToDeleteCB.Location = new Point(232, 235);
            codeProductToDeleteCB.Margin = new Padding(3, 4, 3, 4);
            codeProductToDeleteCB.Name = "codeProductToDeleteCB";
            codeProductToDeleteCB.Size = new Size(138, 36);
            codeProductToDeleteCB.TabIndex = 29;
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteProductBtn.Location = new Point(232, 361);
            deleteProductBtn.Margin = new Padding(3, 4, 3, 4);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new Size(133, 61);
            deleteProductBtn.TabIndex = 4;
            deleteProductBtn.Text = "מחיקה";
            deleteProductBtn.UseVisualStyleBackColor = true;
            deleteProductBtn.Click += deleteProductBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F);
            label13.Location = new Point(225, 149);
            label13.Name = "label13";
            label13.Size = new Size(161, 37);
            label13.TabIndex = 3;
            label13.Text = "מחיקת מוצר";
            // 
            // productsTitle
            // 
            productsTitle.AutoSize = true;
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsTitle.ForeColor = Color.DarkSeaGreen;
            productsTitle.Location = new Point(552, 35);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(228, 81);
            productsTitle.TabIndex = 4;
            productsTitle.Text = "מוצרים";
            // 
            // findProductTxt
            // 
            findProductTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findProductTxt.Location = new Point(918, 145);
            findProductTxt.Margin = new Padding(3, 4, 3, 4);
            findProductTxt.Name = "findProductTxt";
            findProductTxt.RightToLeft = RightToLeft.Yes;
            findProductTxt.Size = new Size(163, 31);
            findProductTxt.TabIndex = 7;
            findProductTxt.TextChanged += findProductTxt_TextChanged;
            findProductTxt.Enter += findProductTxt_Enter;
            findProductTxt.Leave += findProductTxt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(1087, 135);
            label1.Name = "label1";
            label1.Size = new Size(87, 37);
            label1.TabIndex = 6;
            label1.Text = "חיפוש";
            // 
            // productDgv
            // 
            dataGridViewCellStyle1.ForeColor = Color.Salmon;
            productDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            productDgv.BackgroundColor = SystemColors.Control;
            productDgv.BorderStyle = BorderStyle.None;
            productDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDgv.Columns.AddRange(new DataGridViewColumn[] { producerCode, name, amount, price, type });
            productDgv.GridColor = SystemColors.Control;
            productDgv.Location = new Point(664, 203);
            productDgv.Margin = new Padding(3, 4, 3, 4);
            productDgv.Name = "productDgv";
            productDgv.ReadOnly = true;
            productDgv.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            productDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            productDgv.RowHeadersWidth = 51;
            productDgv.Size = new Size(530, 587);
            productDgv.TabIndex = 5;
            // 
            // producerCode
            // 
            producerCode.HeaderText = "קוד";
            producerCode.MinimumWidth = 6;
            producerCode.Name = "producerCode";
            producerCode.ReadOnly = true;
            producerCode.Width = 60;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 130;
            // 
            // amount
            // 
            amount.HeaderText = "כמות במלאי";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 90;
            // 
            // price
            // 
            price.HeaderText = "מחיר";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 70;
            // 
            // type
            // 
            type.HeaderText = "קטגוריה";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            type.Resizable = DataGridViewTriState.True;
            type.SortMode = DataGridViewColumnSortMode.NotSortable;
            type.Width = 90;
            // 
            // orderBtn
            // 
            orderBtn.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderBtn.ForeColor = SystemColors.ActiveCaption;
            orderBtn.Location = new Point(98, 88);
            orderBtn.Margin = new Padding(3, 4, 3, 4);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(358, 69);
            orderBtn.TabIndex = 8;
            orderBtn.Text = "הזמנת מוצר נוסף";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // saerchCategoryCb
            // 
            saerchCategoryCb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saerchCategoryCb.FormattingEnabled = true;
            saerchCategoryCb.Location = new Point(717, 144);
            saerchCategoryCb.Name = "saerchCategoryCb";
            saerchCategoryCb.Size = new Size(177, 33);
            saerchCategoryCb.TabIndex = 9;
            saerchCategoryCb.SelectedIndexChanged += saerchCategoryCb_SelectedIndexChanged;
            // 
            // back
            // 
            back.BackColor = Color.DarkSeaGreen;
            back.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.ControlLightLight;
            back.Location = new Point(98, 16);
            back.Margin = new Padding(3, 4, 3, 4);
            back.Name = "back";
            back.Size = new Size(142, 56);
            back.TabIndex = 10;
            back.Text = "חזרה";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 871);
            Controls.Add(back);
            Controls.Add(saerchCategoryCb);
            Controls.Add(orderBtn);
            Controls.Add(findProductTxt);
            Controls.Add(label1);
            Controls.Add(productDgv);
            Controls.Add(productsTitle);
            Controls.Add(tabProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Product";
            Text = "Product";
            tabProducts.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountN).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNUP).EndInit();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)updatePriceNUD).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabProducts;
        private TabPage addCustomer;
        private NumericUpDown addPriceNUP;
        private Button addCustomerBtn;
        private ComboBox addCategoryComb;
        private TextBox addNameTxt;
        private TabPage updateCustomer;
        private Button updateBtn;
        private TabPage delete;
        private Button deleteProductBtn;
        private Label label13;
        private Label productsTitle;
        private TextBox findProductTxt;
        private Label label1;
        private DataGridView productDgv;
        private NumericUpDown updatePriceNUD;
        private ComboBox updateCategoryCmb;
        private TextBox updateNameTxt;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label7;
        private Button orderBtn;
        private Label label10;
        private ComboBox codeProductToUpdateCB;
        private ComboBox codeProductToDeleteCB;
        private NumericUpDown addAmountN;
        private NumericUpDown quantityNUD;
        private ComboBox saerchCategoryCb;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn producerCode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn type;
        private Button back;
    }
}