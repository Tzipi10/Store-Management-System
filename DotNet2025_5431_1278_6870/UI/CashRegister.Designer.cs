namespace UI
{
    partial class CashRegister
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
            nvagait = new Label();
            searchLbl = new Label();
            searchTb = new TextBox();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            productInOrderLv = new ListView();
            count = new NumericUpDown();
            titel = new Label();
            deletProductFromOrderBtn = new Button();
            label1 = new Label();
            totalPrice = new Label();
            endOrder = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            printDialog1 = new PrintDialog();
            label2 = new Label();
            acountDetailPnl = new Panel();
            label4 = new Label();
            label3 = new Label();
            salesAcount = new ListBox();
            productsAcount = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)count).BeginInit();
            acountDetailPnl.SuspendLayout();
            SuspendLayout();
            // 
            // nvagait
            // 
            nvagait.AutoSize = true;
            nvagait.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nvagait.ForeColor = Color.DarkGray;
            nvagait.Location = new Point(1208, 28);
            nvagait.Name = "nvagait";
            nvagait.Size = new Size(67, 32);
            nvagait.TabIndex = 0;
            nvagait.Text = "קופה";
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchLbl.Location = new Point(1221, 117);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(56, 23);
            searchLbl.TabIndex = 1;
            searchLbl.Text = "חיפוש";
            // 
            // searchTb
            // 
            searchTb.Location = new Point(1079, 144);
            searchTb.Margin = new Padding(3, 4, 3, 4);
            searchTb.Name = "searchTb";
            searchTb.Size = new Size(191, 27);
            searchTb.TabIndex = 2;
            searchTb.Text = "חיפוש מוצר";
            searchTb.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, price, category, id });
            dataGridView1.GridColor = SystemColors.GrayText;
            dataGridView1.Location = new Point(858, 197);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(413, 636);
            dataGridView1.TabIndex = 3;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "מחיר";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 50;
            // 
            // category
            // 
            category.HeaderText = "קטגוריה";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.Width = 125;
            // 
            // id
            // 
            id.HeaderText = "קוד";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 50;
            // 
            // productInOrderLv
            // 
            productInOrderLv.Alignment = ListViewAlignment.Default;
            productInOrderLv.AllowDrop = true;
            productInOrderLv.BackColor = SystemColors.Control;
            productInOrderLv.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productInOrderLv.FullRowSelect = true;
            productInOrderLv.GridLines = true;
            productInOrderLv.Location = new Point(69, 197);
            productInOrderLv.Margin = new Padding(3, 4, 3, 4);
            productInOrderLv.Name = "productInOrderLv";
            productInOrderLv.RightToLeft = RightToLeft.Yes;
            productInOrderLv.RightToLeftLayout = true;
            productInOrderLv.Size = new Size(378, 387);
            productInOrderLv.TabIndex = 4;
            productInOrderLv.UseCompatibleStateImageBehavior = false;
            productInOrderLv.View = View.Details;
            productInOrderLv.SelectedIndexChanged += productInOrderLv_SelectedIndexChanged;
            // 
            // count
            // 
            count.Location = new Point(217, 609);
            count.Margin = new Padding(3, 4, 3, 4);
            count.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            count.Name = "count";
            count.Size = new Size(127, 27);
            count.TabIndex = 6;
            count.TextAlign = HorizontalAlignment.Right;
            count.UpDownAlign = LeftRightAlignment.Left;
            count.Value = new decimal(new int[] { 1, 0, 0, 0 });
            count.ValueChanged += count_ValueChanged;
            // 
            // titel
            // 
            titel.AutoSize = true;
            titel.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            titel.Location = new Point(147, 144);
            titel.Name = "titel";
            titel.Size = new Size(244, 45);
            titel.TabIndex = 7;
            titel.Text = "מוצרים  בהזמנה";
            // 
            // deletProductFromOrderBtn
            // 
            deletProductFromOrderBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletProductFromOrderBtn.Location = new Point(69, 663);
            deletProductFromOrderBtn.Margin = new Padding(3, 4, 3, 4);
            deletProductFromOrderBtn.Name = "deletProductFromOrderBtn";
            deletProductFromOrderBtn.Size = new Size(378, 47);
            deletProductFromOrderBtn.TabIndex = 8;
            deletProductFromOrderBtn.Text = "מחיקת מוצר מהזמנה";
            deletProductFromOrderBtn.UseVisualStyleBackColor = true;
            deletProductFromOrderBtn.Click += deletProductFromOrderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(645, 625);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 9;
            label1.Text = "מחיר לתשלום";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.BackColor = SystemColors.ControlLightLight;
            totalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalPrice.Location = new Point(593, 668);
            totalPrice.Margin = new Padding(0, 0, 0, 3);
            totalPrice.MinimumSize = new Size(217, 40);
            totalPrice.Name = "totalPrice";
            totalPrice.Padding = new Padding(0, 4, 0, 0);
            totalPrice.RightToLeft = RightToLeft.Yes;
            totalPrice.Size = new Size(217, 42);
            totalPrice.TabIndex = 10;
            totalPrice.Text = "0";
            totalPrice.TextAlign = ContentAlignment.TopCenter;
            totalPrice.UseCompatibleTextRendering = true;
            // 
            // endOrder
            // 
            endOrder.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            endOrder.Location = new Point(593, 745);
            endOrder.Margin = new Padding(3, 4, 3, 4);
            endOrder.Name = "endOrder";
            endOrder.Size = new Size(217, 64);
            endOrder.TabIndex = 13;
            endOrder.Text = "סיום ותשלום";
            endOrder.UseVisualStyleBackColor = true;
            endOrder.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(350, 609);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 14;
            label2.Text = " עדכן כמות";
            // 
            // acountDetailPnl
            // 
            acountDetailPnl.BackColor = SystemColors.ButtonHighlight;
            acountDetailPnl.Controls.Add(label4);
            acountDetailPnl.Controls.Add(label3);
            acountDetailPnl.Controls.Add(salesAcount);
            acountDetailPnl.Controls.Add(productsAcount);
            acountDetailPnl.Location = new Point(350, 50);
            acountDetailPnl.Name = "acountDetailPnl";
            acountDetailPnl.Size = new Size(300, 603);
            acountDetailPnl.TabIndex = 15;
            acountDetailPnl.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 59);
            label4.Name = "label4";
            label4.Size = new Size(15, 23);
            label4.TabIndex = 3;
            label4.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 12);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 2;
            label3.Text = "חשבונית";
            // 
            // salesAcount
            // 
            salesAcount.FormattingEnabled = true;
            salesAcount.ItemHeight = 20;
            salesAcount.Location = new Point(14, 342);
            salesAcount.Name = "salesAcount";
            salesAcount.Size = new Size(272, 244);
            salesAcount.TabIndex = 1;
            // 
            // productsAcount
            // 
            productsAcount.FormattingEnabled = true;
            productsAcount.ItemHeight = 20;
            productsAcount.Location = new Point(14, 94);
            productsAcount.Name = "productsAcount";
            productsAcount.Size = new Size(272, 244);
            productsAcount.TabIndex = 0;
            // 
            // CashRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1302, 849);
            Controls.Add(acountDetailPnl);
            Controls.Add(label2);
            Controls.Add(endOrder);
            Controls.Add(totalPrice);
            Controls.Add(label1);
            Controls.Add(deletProductFromOrderBtn);
            Controls.Add(titel);
            Controls.Add(count);
            Controls.Add(productInOrderLv);
            Controls.Add(dataGridView1);
            Controls.Add(searchTb);
            Controls.Add(searchLbl);
            Controls.Add(nvagait);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashRegister";
            Text = "CashRegister";
            TransparencyKey = Color.Silver;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)count).EndInit();
            acountDetailPnl.ResumeLayout(false);
            acountDetailPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nvagait;
        private Label searchLbl;
        private TextBox searchTb;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn id;
        private ListView productInOrderLv;
        private NumericUpDown count;
        private Label titel;
        private Button deletProductFromOrderBtn;
        private Label label1;
        private Label totalPrice;
        private Button endOrder;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private PrintDialog printDialog1;
        private Label label2;
        private Panel acountDetailPnl;
        private ListBox salesAcount;
        private ListBox productsAcount;
        private Label label3;
        private Label label4;
    }
}