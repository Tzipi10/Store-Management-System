namespace UI
{
    partial class Saleman
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
            productsDgv = new DataGridView();
            searchTb = new TextBox();
            searchLbl = new Label();
            newOrderBtn = new Button();
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            count = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productsDgv).BeginInit();
            SuspendLayout();
            // 
            // productsDgv
            // 
            productsDgv.BackgroundColor = SystemColors.Control;
            productsDgv.BorderStyle = BorderStyle.None;
            productsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDgv.Columns.AddRange(new DataGridViewColumn[] { id, name, count, price, category });
            productsDgv.GridColor = SystemColors.GrayText;
            productsDgv.Location = new Point(621, 175);
            productsDgv.Margin = new Padding(3, 4, 3, 4);
            productsDgv.Name = "productsDgv";
            productsDgv.RightToLeft = RightToLeft.Yes;
            productsDgv.RowHeadersWidth = 51;
            productsDgv.Size = new Size(632, 636);
            productsDgv.TabIndex = 6;
            // 
            // searchTb
            // 
            searchTb.AccessibleDescription = "";
            searchTb.Location = new Point(963, 127);
            searchTb.Margin = new Padding(3, 4, 3, 4);
            searchTb.Name = "searchTb";
            searchTb.Size = new Size(191, 27);
            searchTb.TabIndex = 5;
            searchTb.TextAlign = HorizontalAlignment.Right;
            searchTb.TextChanged += searchTb_TextChanged;
            searchTb.Enter += searchTb_Enter;
            searchTb.Leave += searchTb_Leave;
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLbl.Location = new Point(1178, 121);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(75, 31);
            searchLbl.TabIndex = 4;
            searchLbl.Text = "חיפוש";
            // 
            // newOrderBtn
            // 
            newOrderBtn.BackColor = SystemColors.ActiveCaption;
            newOrderBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderBtn.ForeColor = Color.White;
            newOrderBtn.Location = new Point(217, 326);
            newOrderBtn.Margin = new Padding(3, 4, 3, 4);
            newOrderBtn.Name = "newOrderBtn";
            newOrderBtn.Size = new Size(286, 83);
            newOrderBtn.TabIndex = 8;
            newOrderBtn.Text = "הזמנה חדשה";
            newOrderBtn.UseVisualStyleBackColor = false;
            newOrderBtn.Click += newOrderBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 106);
            label1.TabIndex = 7;
            label1.Text = "קופה";
            // 
            // id
            // 
            id.HeaderText = "קוד";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 50;
            // 
            // name
            // 
            name.HeaderText = "שם";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 150;
            // 
            // count
            // 
            count.HeaderText = "כמות";
            count.MinimumWidth = 6;
            count.Name = "count";
            count.Width = 90;
            // 
            // price
            // 
            price.HeaderText = "מחיר";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 90;
            // 
            // category
            // 
            category.HeaderText = "קטגוריה";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.Width = 140;
            // 
            // Saleman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 824);
            Controls.Add(newOrderBtn);
            Controls.Add(label1);
            Controls.Add(productsDgv);
            Controls.Add(searchTb);
            Controls.Add(searchLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Saleman";
            Text = "Saleman";
            ((System.ComponentModel.ISupportInitialize)productsDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsDgv;
        private TextBox searchTb;
        private Label searchLbl;
        private Button newOrderBtn;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn category;
    }
}