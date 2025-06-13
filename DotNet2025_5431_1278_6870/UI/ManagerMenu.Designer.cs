namespace UI
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            CustomerBtn = new Button();
            ProductBtn = new Button();
            SaleBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CustomerBtn
            // 
            CustomerBtn.FlatStyle = FlatStyle.Popup;
            CustomerBtn.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            CustomerBtn.ForeColor = Color.Gold;
            CustomerBtn.Location = new Point(751, 157);
            CustomerBtn.Margin = new Padding(3, 4, 3, 4);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(229, 117);
            CustomerBtn.TabIndex = 0;
            CustomerBtn.Text = "לקוחות";
            CustomerBtn.UseVisualStyleBackColor = true;
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // ProductBtn
            // 
            ProductBtn.FlatStyle = FlatStyle.Popup;
            ProductBtn.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            ProductBtn.ForeColor = Color.Gold;
            ProductBtn.Location = new Point(751, 325);
            ProductBtn.Margin = new Padding(3, 4, 3, 4);
            ProductBtn.Name = "ProductBtn";
            ProductBtn.Size = new Size(229, 117);
            ProductBtn.TabIndex = 0;
            ProductBtn.Text = "מוצרים";
            ProductBtn.UseVisualStyleBackColor = true;
            ProductBtn.Click += ProductBtn_Click;
            // 
            // SaleBtn
            // 
            SaleBtn.FlatStyle = FlatStyle.Popup;
            SaleBtn.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            SaleBtn.ForeColor = Color.Gold;
            SaleBtn.Location = new Point(751, 493);
            SaleBtn.Margin = new Padding(3, 4, 3, 4);
            SaleBtn.Name = "SaleBtn";
            SaleBtn.Size = new Size(229, 117);
            SaleBtn.TabIndex = 0;
            SaleBtn.Text = "מבצעים";
            SaleBtn.UseVisualStyleBackColor = true;
            SaleBtn.Click += SaleBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(606, 796);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 796);
            Controls.Add(pictureBox1);
            Controls.Add(SaleBtn);
            Controls.Add(ProductBtn);
            Controls.Add(CustomerBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CustomerBtn;
        private Button ProductBtn;
        private Button SaleBtn;
        private PictureBox pictureBox1;
    }
}