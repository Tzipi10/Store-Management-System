namespace UI
{
    partial class CustomerDetail
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
            customerDetails = new GroupBox();
            preferance = new ComboBox();
            label1 = new Label();
            addresTxb = new TextBox();
            nameTxb = new TextBox();
            phoneTxb = new TextBox();
            idTxb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            newOrderBtn = new Button();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            customerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // customerDetails
            // 
            customerDetails.Controls.Add(preferance);
            customerDetails.Controls.Add(label1);
            customerDetails.Controls.Add(addresTxb);
            customerDetails.Controls.Add(nameTxb);
            customerDetails.Controls.Add(phoneTxb);
            customerDetails.Controls.Add(idTxb);
            customerDetails.Controls.Add(label6);
            customerDetails.Controls.Add(label5);
            customerDetails.Controls.Add(label4);
            customerDetails.Controls.Add(label3);
            customerDetails.Location = new Point(295, 92);
            customerDetails.Margin = new Padding(3, 4, 3, 4);
            customerDetails.Name = "customerDetails";
            customerDetails.Padding = new Padding(3, 4, 3, 4);
            customerDetails.Size = new Size(325, 339);
            customerDetails.TabIndex = 14;
            customerDetails.TabStop = false;
            customerDetails.Text = " ";
            // 
            // preferance
            // 
            preferance.FormattingEnabled = true;
            preferance.Location = new Point(7, 276);
            preferance.Margin = new Padding(3, 4, 3, 4);
            preferance.Name = "preferance";
            preferance.Size = new Size(182, 28);
            preferance.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label1.Location = new Point(234, 276);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 8;
            label1.Text = "סוג לקוח";
            // 
            // addresTxb
            // 
            addresTxb.Location = new Point(7, 219);
            addresTxb.Margin = new Padding(3, 4, 3, 4);
            addresTxb.Name = "addresTxb";
            addresTxb.Size = new Size(182, 27);
            addresTxb.TabIndex = 7;
            // 
            // nameTxb
            // 
            nameTxb.Location = new Point(7, 112);
            nameTxb.Margin = new Padding(3, 4, 3, 4);
            nameTxb.Name = "nameTxb";
            nameTxb.Size = new Size(182, 27);
            nameTxb.TabIndex = 6;
            // 
            // phoneTxb
            // 
            phoneTxb.Location = new Point(7, 165);
            phoneTxb.Margin = new Padding(3, 4, 3, 4);
            phoneTxb.Name = "phoneTxb";
            phoneTxb.Size = new Size(182, 27);
            phoneTxb.TabIndex = 5;
            // 
            // idTxb
            // 
            idTxb.Location = new Point(7, 59);
            idTxb.Margin = new Padding(3, 4, 3, 4);
            idTxb.Name = "idTxb";
            idTxb.Size = new Size(182, 27);
            idTxb.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label6.Location = new Point(272, 119);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 3;
            label6.Text = "שם";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label5.Location = new Point(256, 173);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 2;
            label5.Text = "טלפון";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label4.Location = new Point(256, 224);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 1;
            label4.Text = "כתובת";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label3.Location = new Point(219, 64);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 0;
            label3.Text = "מזהה לקוח";
            // 
            // newOrderBtn
            // 
            newOrderBtn.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newOrderBtn.Location = new Point(295, 472);
            newOrderBtn.Margin = new Padding(3, 4, 3, 4);
            newOrderBtn.Name = "newOrderBtn";
            newOrderBtn.Size = new Size(325, 73);
            newOrderBtn.TabIndex = 15;
            newOrderBtn.Text = "מעבר להזמנה";
            newOrderBtn.UseVisualStyleBackColor = true;
            newOrderBtn.Click += newOrderBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(352, 26);
            label2.Name = "label2";
            label2.Size = new Size(225, 62);
            label2.TabIndex = 16;
            label2.Text = "התחברות";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(newOrderBtn);
            Controls.Add(customerDetails);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerDetail";
            Text = "CustomerDetail";
            customerDetails.ResumeLayout(false);
            customerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox customerDetails;
        private TextBox addresTxb;
        private TextBox nameTxb;
        private TextBox phoneTxb;
        private TextBox idTxb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button newOrderBtn;
        private ComboBox preferance;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}