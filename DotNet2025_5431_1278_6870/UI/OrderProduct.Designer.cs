namespace UI
{
    partial class OrderProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProduct));
            productsDGV = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            priceTxt = new TextBox();
            nameTxt = new TextBox();
            amountTxt = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            categoryCmb = new ComboBox();
            orderProductBtn = new Button();
            planePb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)productsDGV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planePb).BeginInit();
            SuspendLayout();
            // 
            // productsDGV
            // 
            productsDGV.BackgroundColor = SystemColors.Control;
            productsDGV.BorderStyle = BorderStyle.None;
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Columns.AddRange(new DataGridViewColumn[] { code, name, amount, price, category });
            productsDGV.GridColor = SystemColors.ScrollBar;
            productsDGV.Location = new Point(671, 180);
            productsDGV.Margin = new Padding(3, 4, 3, 4);
            productsDGV.Name = "productsDGV";
            productsDGV.ReadOnly = true;
            productsDGV.RightToLeft = RightToLeft.Yes;
            productsDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            productsDGV.Size = new Size(558, 665);
            productsDGV.TabIndex = 0;
            productsDGV.CellDoubleClick += productsDGV_CellDoubleClick;
            // 
            // code
            // 
            code.HeaderText = "קוד";
            code.MinimumWidth = 6;
            code.Name = "code";
            code.ReadOnly = true;
            code.Width = 70;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 120;
            // 
            // amount
            // 
            amount.HeaderText = "כמות";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 70;
            // 
            // price
            // 
            price.HeaderText = "מחיר";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 125;
            // 
            // category
            // 
            category.HeaderText = "קטגוריה";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(982, 115);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 1;
            label1.Text = "מוצרים שאזלו מהמלאי";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(597, 63);
            label2.Name = "label2";
            label2.Size = new Size(245, 48);
            label2.TabIndex = 2;
            label2.Text = "הזמנת מוצרים";
            // 
            // priceTxt
            // 
            priceTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTxt.Location = new Point(98, 335);
            priceTxt.Margin = new Padding(3, 4, 3, 4);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(145, 34);
            priceTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(98, 131);
            nameTxt.Margin = new Padding(3, 4, 3, 4);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(145, 34);
            nameTxt.TabIndex = 5;
            // 
            // amountTxt
            // 
            amountTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountTxt.Location = new Point(98, 267);
            amountTxt.Margin = new Padding(3, 4, 3, 4);
            amountTxt.Name = "amountTxt";
            amountTxt.Size = new Size(145, 34);
            amountTxt.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(categoryCmb);
            groupBox1.Controls.Add(orderProductBtn);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(priceTxt);
            groupBox1.Controls.Add(amountTxt);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(120, 169);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(472, 573);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "הזמנת מוצר";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 203);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 12;
            label6.Text = "קטגוריה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 269);
            label5.Name = "label5";
            label5.Size = new Size(151, 32);
            label5.TabIndex = 11;
            label5.Text = "כמות להזמנה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 336);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 10;
            label4.Text = "מחיר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 136);
            label3.Name = "label3";
            label3.Size = new Size(50, 32);
            label3.TabIndex = 9;
            label3.Text = "שם";
            // 
            // categoryCmb
            // 
            categoryCmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryCmb.FormattingEnabled = true;
            categoryCmb.Location = new Point(98, 199);
            categoryCmb.Margin = new Padding(3, 4, 3, 4);
            categoryCmb.Name = "categoryCmb";
            categoryCmb.RightToLeft = RightToLeft.No;
            categoryCmb.Size = new Size(145, 36);
            categoryCmb.TabIndex = 8;
            // 
            // orderProductBtn
            // 
            orderProductBtn.Font = new Font("Segoe UI", 16F);
            orderProductBtn.Location = new Point(148, 417);
            orderProductBtn.Margin = new Padding(3, 4, 3, 4);
            orderProductBtn.Name = "orderProductBtn";
            orderProductBtn.Size = new Size(189, 68);
            orderProductBtn.TabIndex = 7;
            orderProductBtn.Text = "הזמנת מוצר";
            orderProductBtn.UseVisualStyleBackColor = true;
            orderProductBtn.Click += orderProductBtn_Click;
            // 
            // planePb
            // 
            planePb.Image = (Image)resources.GetObject("planePb.Image");
            planePb.Location = new Point(743, 487);
            planePb.Name = "planePb";
            planePb.Size = new Size(550, 623);
            planePb.SizeMode = PictureBoxSizeMode.Zoom;
            planePb.TabIndex = 8;
            planePb.TabStop = false;
            // 
            // OrderProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1288, 861);
            Controls.Add(planePb);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productsDGV);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderProduct";
            Text = "OrderProduct";
            ((System.ComponentModel.ISupportInitialize)productsDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)planePb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsDGV;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox priceTxt;
        private TextBox nameTxt;
        private TextBox amountTxt;
        protected GroupBox groupBox1;
        private Button orderProductBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox categoryCmb;
        private PictureBox planePb;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn category;
    }
}