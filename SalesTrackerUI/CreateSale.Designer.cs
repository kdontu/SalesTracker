namespace SalesTrackerUI
{
    partial class CreateSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            comboBox_SalesPersons = new ComboBox();
            comboBox_Products = new ComboBox();
            comboBox_Customers = new ComboBox();
            txtSaleDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(429, 410);
            button2.Name = "button2";
            button2.Size = new Size(295, 69);
            button2.TabIndex = 3;
            button2.Text = "Create Sale";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox_SalesPersons
            // 
            comboBox_SalesPersons.FormattingEnabled = true;
            comboBox_SalesPersons.Location = new Point(249, 157);
            comboBox_SalesPersons.Name = "comboBox_SalesPersons";
            comboBox_SalesPersons.Size = new Size(475, 56);
            comboBox_SalesPersons.TabIndex = 5;
            // 
            // comboBox_Products
            // 
            comboBox_Products.FormattingEnabled = true;
            comboBox_Products.Location = new Point(249, 81);
            comboBox_Products.Name = "comboBox_Products";
            comboBox_Products.Size = new Size(475, 56);
            comboBox_Products.TabIndex = 6;
            // 
            // comboBox_Customers
            // 
            comboBox_Customers.FormattingEnabled = true;
            comboBox_Customers.Location = new Point(249, 219);
            comboBox_Customers.Name = "comboBox_Customers";
            comboBox_Customers.Size = new Size(475, 56);
            comboBox_Customers.TabIndex = 7;
            // 
            // txtSaleDate
            // 
            txtSaleDate.Location = new Point(249, 289);
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.Size = new Size(475, 55);
            txtSaleDate.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 81);
            label1.Name = "label1";
            label1.Size = new Size(167, 48);
            label1.TabIndex = 11;
            label1.Text = "Products:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 219);
            label2.Name = "label2";
            label2.Size = new Size(188, 48);
            label2.TabIndex = 13;
            label2.Text = "Customers";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 144);
            label3.Name = "label3";
            label3.Size = new Size(222, 48);
            label3.TabIndex = 14;
            label3.Text = "SalesPersons";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 289);
            label4.Name = "label4";
            label4.Size = new Size(184, 48);
            label4.TabIndex = 16;
            label4.Text = "Sales Date";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // CreateSale
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSaleDate);
            Controls.Add(comboBox_Customers);
            Controls.Add(comboBox_Products);
            Controls.Add(comboBox_SalesPersons);
            Controls.Add(button2);
            Name = "CreateSale";
            Size = new Size(842, 585);
            Load += CreateSale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ComboBox comboBox_SalesPersons;
        private ComboBox comboBox_Products;
        private ComboBox comboBox_Customers;
        private TextBox txtSaleDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
