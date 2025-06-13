namespace UI
{
    partial class Sale
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
            findSaleTxt = new TextBox();
            label1 = new Label();
            salesDgv = new DataGridView();
            productsTitle = new Label();
            tabProducts = new TabControl();
            addCustomer = new TabPage();
            addAmountSaleNUD = new NumericUpDown();
            isClubCB = new CheckBox();
            label12 = new Label();
            addProductIdTxt = new TextBox();
            endSaleDTP = new DateTimePicker();
            startSaleDTP = new DateTimePicker();
            addPriceNUD = new NumericUpDown();
            addSaleBtn = new Button();
            label10 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            updateCustomer = new TabPage();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label14 = new Label();
            codeSaleToUpdateCB = new ComboBox();
            label15 = new Label();
            clubCB = new CheckBox();
            amountSaleNUD = new NumericUpDown();
            productIdTxt = new TextBox();
            EndDate = new DateTimePicker();
            updateBtn = new Button();
            startDate = new DateTimePicker();
            priceNum = new NumericUpDown();
            delete = new TabPage();
            saleCodeToDeleteCB = new ComboBox();
            deleteSaleBtn = new Button();
            label13 = new Label();
            errorProvider1 = new ErrorProvider(components);
            back = new Button();
            producerCode = new DataGridViewTextBoxColumn();
            productId = new DataGridViewTextBoxColumn();
            amountSale = new DataGridViewTextBoxColumn();
            priceSale = new DataGridViewTextBoxColumn();
            isClub = new DataGridViewCheckBoxColumn();
            StartSale = new DataGridViewTextBoxColumn();
            EndSale = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)salesDgv).BeginInit();
            tabProducts.SuspendLayout();
            addCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountSaleNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNUD).BeginInit();
            updateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountSaleNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // findSaleTxt
            // 
            findSaleTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            findSaleTxt.Location = new Point(957, 147);
            findSaleTxt.Margin = new Padding(3, 4, 3, 4);
            findSaleTxt.Name = "findSaleTxt";
            findSaleTxt.RightToLeft = RightToLeft.Yes;
            findSaleTxt.Size = new Size(195, 30);
            findSaleTxt.TabIndex = 12;
            findSaleTxt.TextChanged += findSaleTxt_TextChanged;
            findSaleTxt.Enter += findSaleTxt_Enter;
            findSaleTxt.Leave += findSaleTxt_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(1158, 137);
            label1.Name = "label1";
            label1.Size = new Size(87, 37);
            label1.TabIndex = 11;
            label1.Text = "חיפוש";
            // 
            // salesDgv
            // 
            salesDgv.BackgroundColor = SystemColors.Control;
            salesDgv.BorderStyle = BorderStyle.None;
            salesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDgv.Columns.AddRange(new DataGridViewColumn[] { producerCode, productId, amountSale, priceSale, isClub, StartSale, EndSale });
            salesDgv.GridColor = SystemColors.Control;
            salesDgv.Location = new Point(566, 187);
            salesDgv.Margin = new Padding(3, 4, 3, 4);
            salesDgv.Name = "salesDgv";
            salesDgv.RightToLeft = RightToLeft.Yes;
            salesDgv.RowHeadersWidth = 51;
            salesDgv.Size = new Size(698, 587);
            salesDgv.TabIndex = 10;
            // 
            // productsTitle
            // 
            productsTitle.AutoSize = true;
            productsTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsTitle.ForeColor = Color.FromArgb(255, 128, 128);
            productsTitle.Location = new Point(543, 39);
            productsTitle.Name = "productsTitle";
            productsTitle.Size = new Size(250, 81);
            productsTitle.TabIndex = 9;
            productsTitle.Text = "מבצעים";
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(addCustomer);
            tabProducts.Controls.Add(updateCustomer);
            tabProducts.Controls.Add(delete);
            tabProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabProducts.Location = new Point(26, 169);
            tabProducts.Margin = new Padding(3, 4, 3, 4);
            tabProducts.Name = "tabProducts";
            tabProducts.RightToLeft = RightToLeft.Yes;
            tabProducts.RightToLeftLayout = true;
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(521, 587);
            tabProducts.TabIndex = 8;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(addAmountSaleNUD);
            addCustomer.Controls.Add(isClubCB);
            addCustomer.Controls.Add(label12);
            addCustomer.Controls.Add(addProductIdTxt);
            addCustomer.Controls.Add(endSaleDTP);
            addCustomer.Controls.Add(startSaleDTP);
            addCustomer.Controls.Add(addPriceNUD);
            addCustomer.Controls.Add(addSaleBtn);
            addCustomer.Controls.Add(label10);
            addCustomer.Controls.Add(label6);
            addCustomer.Controls.Add(label2);
            addCustomer.Controls.Add(label5);
            addCustomer.Controls.Add(label3);
            addCustomer.Location = new Point(4, 37);
            addCustomer.Margin = new Padding(3, 4, 3, 4);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3, 4, 3, 4);
            addCustomer.Size = new Size(513, 546);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            // 
            // addAmountSaleNUD
            // 
            addAmountSaleNUD.Location = new Point(142, 155);
            addAmountSaleNUD.Margin = new Padding(3, 4, 3, 4);
            addAmountSaleNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            addAmountSaleNUD.Name = "addAmountSaleNUD";
            addAmountSaleNUD.Size = new Size(154, 34);
            addAmountSaleNUD.TabIndex = 10;
            addAmountSaleNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // isClubCB
            // 
            isClubCB.AutoSize = true;
            isClubCB.Location = new Point(218, 396);
            isClubCB.Margin = new Padding(3, 4, 3, 4);
            isClubCB.Name = "isClubCB";
            isClubCB.Size = new Size(18, 17);
            isClubCB.TabIndex = 9;
            isClubCB.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(398, 385);
            label12.Name = "label12";
            label12.Size = new Size(62, 28);
            label12.TabIndex = 8;
            label12.Text = "מועדון";
            // 
            // addProductIdTxt
            // 
            addProductIdTxt.Location = new Point(141, 92);
            addProductIdTxt.Margin = new Padding(3, 4, 3, 4);
            addProductIdTxt.Name = "addProductIdTxt";
            addProductIdTxt.Size = new Size(155, 34);
            addProductIdTxt.TabIndex = 7;
            // 
            // endSaleDTP
            // 
            endSaleDTP.Location = new Point(141, 332);
            endSaleDTP.Margin = new Padding(3, 4, 3, 4);
            endSaleDTP.Name = "endSaleDTP";
            endSaleDTP.Size = new Size(155, 34);
            endSaleDTP.TabIndex = 6;
            // 
            // startSaleDTP
            // 
            startSaleDTP.Location = new Point(141, 272);
            startSaleDTP.Margin = new Padding(3, 4, 3, 4);
            startSaleDTP.Name = "startSaleDTP";
            startSaleDTP.Size = new Size(155, 34);
            startSaleDTP.TabIndex = 6;
            // 
            // addPriceNUD
            // 
            addPriceNUD.Location = new Point(142, 212);
            addPriceNUD.Margin = new Padding(3, 4, 3, 4);
            addPriceNUD.Name = "addPriceNUD";
            addPriceNUD.Size = new Size(154, 34);
            addPriceNUD.TabIndex = 4;
            // 
            // addSaleBtn
            // 
            addSaleBtn.Location = new Point(206, 444);
            addSaleBtn.Margin = new Padding(3, 4, 3, 4);
            addSaleBtn.Name = "addSaleBtn";
            addSaleBtn.Size = new Size(177, 56);
            addSaleBtn.TabIndex = 3;
            addSaleBtn.Text = "הוספה";
            addSaleBtn.UseVisualStyleBackColor = true;
            addSaleBtn.Click += addSaleBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(350, 327);
            label10.Name = "label10";
            label10.Size = new Size(110, 28);
            label10.TabIndex = 0;
            label10.Text = "תאריך סיום";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(321, 269);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 0;
            label6.Text = "תאריך התחלה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(406, 211);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 0;
            label2.Text = "מחיר";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(341, 153);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 0;
            label5.Text = "כמות למבצע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(374, 95);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 0;
            label3.Text = "קוד מוצר";
            // 
            // updateCustomer
            // 
            updateCustomer.Controls.Add(label4);
            updateCustomer.Controls.Add(label7);
            updateCustomer.Controls.Add(label8);
            updateCustomer.Controls.Add(label9);
            updateCustomer.Controls.Add(label11);
            updateCustomer.Controls.Add(label14);
            updateCustomer.Controls.Add(codeSaleToUpdateCB);
            updateCustomer.Controls.Add(label15);
            updateCustomer.Controls.Add(clubCB);
            updateCustomer.Controls.Add(amountSaleNUD);
            updateCustomer.Controls.Add(productIdTxt);
            updateCustomer.Controls.Add(EndDate);
            updateCustomer.Controls.Add(updateBtn);
            updateCustomer.Controls.Add(startDate);
            updateCustomer.Controls.Add(priceNum);
            updateCustomer.Location = new Point(4, 37);
            updateCustomer.Margin = new Padding(3, 4, 3, 4);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Padding = new Padding(3, 4, 3, 4);
            updateCustomer.Size = new Size(513, 546);
            updateCustomer.TabIndex = 1;
            updateCustomer.Text = "עדכון";
            updateCustomer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(405, 391);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 34;
            label4.Text = "מועדון";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(357, 333);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 29;
            label7.Text = "תאריך סיום";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(328, 275);
            label8.Name = "label8";
            label8.Size = new Size(139, 28);
            label8.TabIndex = 30;
            label8.Text = "תאריך התחלה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(413, 217);
            label9.Name = "label9";
            label9.Size = new Size(54, 28);
            label9.TabIndex = 31;
            label9.Text = "מחיר";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(347, 159);
            label11.Name = "label11";
            label11.Size = new Size(120, 28);
            label11.TabIndex = 32;
            label11.Text = "כמות למבצע";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(381, 101);
            label14.Name = "label14";
            label14.Size = new Size(86, 28);
            label14.TabIndex = 33;
            label14.Text = "קוד מוצר";
            // 
            // codeSaleToUpdateCB
            // 
            codeSaleToUpdateCB.FormattingEnabled = true;
            codeSaleToUpdateCB.Location = new Point(160, 32);
            codeSaleToUpdateCB.Margin = new Padding(3, 4, 3, 4);
            codeSaleToUpdateCB.Name = "codeSaleToUpdateCB";
            codeSaleToUpdateCB.Size = new Size(157, 36);
            codeSaleToUpdateCB.TabIndex = 28;
            codeSaleToUpdateCB.SelectedValueChanged += codeSaleToUpdateCB_selectedValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(336, 35);
            label15.Name = "label15";
            label15.Size = new Size(141, 28);
            label15.TabIndex = 27;
            label15.Text = "בחר קוד מבצע";
            // 
            // clubCB
            // 
            clubCB.AutoSize = true;
            clubCB.Location = new Point(239, 399);
            clubCB.Margin = new Padding(3, 4, 3, 4);
            clubCB.Name = "clubCB";
            clubCB.Size = new Size(18, 17);
            clubCB.TabIndex = 25;
            clubCB.UseVisualStyleBackColor = true;
            // 
            // amountSaleNUD
            // 
            amountSaleNUD.Location = new Point(161, 159);
            amountSaleNUD.Margin = new Padding(3, 4, 3, 4);
            amountSaleNUD.Name = "amountSaleNUD";
            amountSaleNUD.Size = new Size(155, 34);
            amountSaleNUD.TabIndex = 23;
            amountSaleNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // productIdTxt
            // 
            productIdTxt.Location = new Point(160, 99);
            productIdTxt.Margin = new Padding(3, 4, 3, 4);
            productIdTxt.Name = "productIdTxt";
            productIdTxt.Size = new Size(157, 34);
            productIdTxt.TabIndex = 14;
            // 
            // EndDate
            // 
            EndDate.Location = new Point(160, 339);
            EndDate.Margin = new Padding(3, 4, 3, 4);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(157, 34);
            EndDate.TabIndex = 21;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            updateBtn.Location = new Point(179, 448);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(177, 56);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "עדכון";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // startDate
            // 
            startDate.Location = new Point(160, 279);
            startDate.Margin = new Padding(3, 4, 3, 4);
            startDate.Name = "startDate";
            startDate.Size = new Size(157, 34);
            startDate.TabIndex = 22;
            // 
            // priceNum
            // 
            priceNum.Location = new Point(161, 219);
            priceNum.Margin = new Padding(3, 4, 3, 4);
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(155, 34);
            priceNum.TabIndex = 19;
            // 
            // delete
            // 
            delete.Controls.Add(saleCodeToDeleteCB);
            delete.Controls.Add(deleteSaleBtn);
            delete.Controls.Add(label13);
            delete.Location = new Point(4, 37);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Padding = new Padding(3, 4, 3, 4);
            delete.Size = new Size(513, 546);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // saleCodeToDeleteCB
            // 
            saleCodeToDeleteCB.FormattingEnabled = true;
            saleCodeToDeleteCB.Location = new Point(194, 232);
            saleCodeToDeleteCB.Margin = new Padding(3, 4, 3, 4);
            saleCodeToDeleteCB.Name = "saleCodeToDeleteCB";
            saleCodeToDeleteCB.Size = new Size(138, 36);
            saleCodeToDeleteCB.TabIndex = 29;
            // 
            // deleteSaleBtn
            // 
            deleteSaleBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSaleBtn.Location = new Point(197, 343);
            deleteSaleBtn.Margin = new Padding(3, 4, 3, 4);
            deleteSaleBtn.Name = "deleteSaleBtn";
            deleteSaleBtn.Size = new Size(133, 61);
            deleteSaleBtn.TabIndex = 4;
            deleteSaleBtn.Text = "מחיקה";
            deleteSaleBtn.UseVisualStyleBackColor = true;
            deleteSaleBtn.Click += deleteSaleBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(173, 151);
            label13.Name = "label13";
            label13.Size = new Size(181, 38);
            label13.TabIndex = 3;
            label13.Text = "מחיקת מבצע";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 128, 128);
            back.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.ControlLightLight;
            back.Location = new Point(31, 39);
            back.Margin = new Padding(3, 4, 3, 4);
            back.Name = "back";
            back.Size = new Size(142, 56);
            back.TabIndex = 13;
            back.Text = "חזרה";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // producerCode
            // 
            producerCode.HeaderText = "קוד";
            producerCode.MinimumWidth = 6;
            producerCode.Name = "producerCode";
            producerCode.Width = 35;
            // 
            // productId
            // 
            productId.HeaderText = "קוד מוצר";
            productId.MinimumWidth = 6;
            productId.Name = "productId";
            productId.Width = 80;
            // 
            // amountSale
            // 
            amountSale.HeaderText = "כמות למבצע";
            amountSale.MinimumWidth = 6;
            amountSale.Name = "amountSale";
            amountSale.Width = 70;
            // 
            // priceSale
            // 
            priceSale.HeaderText = "מחיר";
            priceSale.MinimumWidth = 6;
            priceSale.Name = "priceSale";
            priceSale.Width = 70;
            // 
            // isClub
            // 
            isClub.HeaderText = "מועדון";
            isClub.MinimumWidth = 6;
            isClub.Name = "isClub";
            isClub.Resizable = DataGridViewTriState.True;
            isClub.SortMode = DataGridViewColumnSortMode.Automatic;
            isClub.Width = 60;
            // 
            // StartSale
            // 
            StartSale.HeaderText = "תאריך התחלה";
            StartSale.MinimumWidth = 6;
            StartSale.Name = "StartSale";
            StartSale.Width = 130;
            // 
            // EndSale
            // 
            EndSale.HeaderText = "תאריך סיום";
            EndSale.MinimumWidth = 6;
            EndSale.Name = "EndSale";
            EndSale.Width = 130;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 832);
            Controls.Add(back);
            Controls.Add(findSaleTxt);
            Controls.Add(label1);
            Controls.Add(salesDgv);
            Controls.Add(productsTitle);
            Controls.Add(tabProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sale";
            Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)salesDgv).EndInit();
            tabProducts.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addAmountSaleNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)addPriceNUD).EndInit();
            updateCustomer.ResumeLayout(false);
            updateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountSaleNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox findSaleTxt;
        private Label label1;
        private DataGridView salesDgv;
        private Label productsTitle;
        private TabControl tabProducts;
        private TabPage addCustomer;
        private NumericUpDown addPriceNUD;
        private Button addSaleBtn;
        private Label label2;
        private Label label5;
        private Label label3;
        private TabPage updateCustomer;
        private Button updateBtn;
        private TabPage delete;
        private Button deleteSaleBtn;
        private Label label13;
        private ComboBox productNameCb;
        private DateTimePicker startSaleDTP;
        private DateTimePicker endSaleDTP;
        private Label label10;
        private Label label6;
        private DateTimePicker EndDate;
        private DateTimePicker startDate;
        private ComboBox nameCb;
        private NumericUpDown priceNum;
        private TextBox addProductIdTxt;
        private TextBox productIdTxt;
        private CheckBox isClubCB;
        private Label label12;
        private NumericUpDown addAmountSaleNUD;
        private NumericUpDown amountSaleNUD;
        private Label label15;
        private CheckBox clubCB;
        private ComboBox codeSaleToUpdateCB;
        private ComboBox saleCodeToDeleteCB;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label14;
        private ErrorProvider errorProvider1;
        private Button back;
        private DataGridViewTextBoxColumn producerCode;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn amountSale;
        private DataGridViewTextBoxColumn priceSale;
        private DataGridViewCheckBoxColumn isClub;
        private DataGridViewTextBoxColumn StartSale;
        private DataGridViewTextBoxColumn EndSale;
    }
}