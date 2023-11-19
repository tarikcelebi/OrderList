namespace OrderList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetOrderList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            lstEmployees = new ListBox();
            lstTransportCompany = new ListBox();
            lstOrders = new ListBox();
            SuspendLayout();
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.Location = new Point(43, 12);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(97, 23);
            btnGetOrderList.TabIndex = 1;
            btnGetOrderList.Text = "Get Order List";
            btnGetOrderList.UseVisualStyleBackColor = true;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(179, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(338, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(489, 12);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(12, 41);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(183, 199);
            lstEmployees.TabIndex = 5;
            // 
            // lstTransportCompany
            // 
            lstTransportCompany.FormattingEnabled = true;
            lstTransportCompany.ItemHeight = 15;
            lstTransportCompany.Location = new Point(12, 252);
            lstTransportCompany.Name = "lstTransportCompany";
            lstTransportCompany.Size = new Size(183, 109);
            lstTransportCompany.TabIndex = 6;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 15;
            lstOrders.Location = new Point(201, 41);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(363, 319);
            lstOrders.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 373);
            Controls.Add(lstOrders);
            Controls.Add(lstTransportCompany);
            Controls.Add(lstEmployees);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnGetOrderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private ListBox lstEmployees;
        private ListBox lstTransportCompany;
        private ListBox lstOrders;
    }
}