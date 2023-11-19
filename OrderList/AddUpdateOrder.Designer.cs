namespace OrderList
{
    partial class AddUpdateOrder
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbEmployees = new ComboBox();
            cmbShippers = new ComboBox();
            txtShipCity = new TextBox();
            dtpOrderDAte = new DateTimePicker();
            btnAddorUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 58);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 97);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Ship City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 140);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Shipper";
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(109, 17);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(200, 23);
            cmbEmployees.TabIndex = 4;
            // 
            // cmbShippers
            // 
            cmbShippers.FormattingEnabled = true;
            cmbShippers.Location = new Point(109, 137);
            cmbShippers.Name = "cmbShippers";
            cmbShippers.Size = new Size(200, 23);
            cmbShippers.TabIndex = 5;
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(109, 94);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(200, 23);
            txtShipCity.TabIndex = 6;
            // 
            // dtpOrderDAte
            // 
            dtpOrderDAte.Location = new Point(109, 52);
            dtpOrderDAte.Name = "dtpOrderDAte";
            dtpOrderDAte.Size = new Size(200, 23);
            dtpOrderDAte.TabIndex = 7;
            // 
            // btnAddorUpdate
            // 
            btnAddorUpdate.Location = new Point(109, 172);
            btnAddorUpdate.Name = "btnAddorUpdate";
            btnAddorUpdate.Size = new Size(200, 38);
            btnAddorUpdate.TabIndex = 8;
            btnAddorUpdate.Text = "Add";
            btnAddorUpdate.UseVisualStyleBackColor = true;
            btnAddorUpdate.Click += btnAddorUpdate_Click;
            // 
            // AddUpdateOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 222);
            Controls.Add(btnAddorUpdate);
            Controls.Add(dtpOrderDAte);
            Controls.Add(txtShipCity);
            Controls.Add(cmbShippers);
            Controls.Add(cmbEmployees);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUpdateOrder";
            Text = "AddUpdateOrder";
            Load += AddUpdateOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbEmployees;
        private ComboBox cmbShippers;
        private TextBox txtShipCity;
        private DateTimePicker dtpOrderDAte;
        private Button btnAddorUpdate;
    }
}