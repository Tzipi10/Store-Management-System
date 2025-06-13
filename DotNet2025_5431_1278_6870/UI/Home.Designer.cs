namespace UI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            manageBtn = new Button();
            cashRegisterBtn = new Button();
            SuspendLayout();
            // 
            // manageBtn
            // 
            manageBtn.BackColor = Color.IndianRed;
            manageBtn.FlatStyle = FlatStyle.Flat;
            manageBtn.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageBtn.Location = new Point(435, 349);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(156, 70);
            manageBtn.TabIndex = 0;
            manageBtn.UseVisualStyleBackColor = false;
            manageBtn.Click += manageBtn_Click;
            // 
            // cashRegisterBtn
            // 
            cashRegisterBtn.BackColor = Color.IndianRed;
            cashRegisterBtn.FlatStyle = FlatStyle.Flat;
            cashRegisterBtn.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashRegisterBtn.Location = new Point(650, 354);
            cashRegisterBtn.Name = "cashRegisterBtn";
            cashRegisterBtn.Size = new Size(162, 66);
            cashRegisterBtn.TabIndex = 1;
            cashRegisterBtn.UseVisualStyleBackColor = false;
            cashRegisterBtn.Click += cashRegisterBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1252, 720);
            Controls.Add(cashRegisterBtn);
            Controls.Add(manageBtn);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button manageBtn;
        private Button cashRegisterBtn;
    }
}