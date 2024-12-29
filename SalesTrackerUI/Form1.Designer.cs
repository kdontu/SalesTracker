namespace SalesTracker
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
            tabCommisionReport = new TabPage();
            tabSales = new TabPage();
            button3 = new Button();
            dataGridViewSales = new DataGridView();
            tabCustomers = new TabPage();
            dataGridViewCustomer = new DataGridView();
            tabProducts = new TabPage();
            button2 = new Button();
            dataGridViewProducts = new DataGridView();
            tabSalesPersons = new TabPage();
            button1 = new Button();
            dataGridViewSalesPersons = new DataGridView();
            SalesTracker = new TabControl();
            tabDiscount = new TabPage();
            dataGridView2 = new DataGridView();
            tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabSalesPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesPersons).BeginInit();
            SalesTracker.SuspendLayout();
            tabDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabCommisionReport
            // 
            tabCommisionReport.Location = new Point(12, 69);
            tabCommisionReport.Name = "tabCommisionReport";
            tabCommisionReport.Size = new Size(2566, 684);
            tabCommisionReport.TabIndex = 4;
            tabCommisionReport.Text = "Commission Report";
            tabCommisionReport.UseVisualStyleBackColor = true;
            // 
            // tabSales
            // 
            tabSales.Controls.Add(button3);
            tabSales.Controls.Add(dataGridViewSales);
            tabSales.Location = new Point(12, 69);
            tabSales.Name = "tabSales";
            tabSales.Size = new Size(2566, 684);
            tabSales.TabIndex = 3;
            tabSales.Text = "Sales";
            tabSales.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1082, 486);
            button3.Name = "button3";
            button3.Size = new Size(295, 69);
            button3.TabIndex = 2;
            button3.Text = "Create Sale";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(3, 3);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 123;
            dataGridViewSales.Size = new Size(1374, 450);
            dataGridViewSales.TabIndex = 0;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(dataGridViewCustomer);
            tabCustomers.Location = new Point(12, 69);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(2566, 684);
            tabCustomers.TabIndex = 2;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(6, 6);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 123;
            dataGridViewCustomer.Size = new Size(1850, 450);
            dataGridViewCustomer.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(button2);
            tabProducts.Controls.Add(dataGridViewProducts);
            tabProducts.Location = new Point(12, 69);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(2566, 684);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1935, 496);
            button2.Name = "button2";
            button2.Size = new Size(295, 69);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(6, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 123;
            dataGridViewProducts.Size = new Size(2548, 450);
            dataGridViewProducts.TabIndex = 0;
            // 
            // tabSalesPersons
            // 
            tabSalesPersons.Controls.Add(button1);
            tabSalesPersons.Controls.Add(dataGridViewSalesPersons);
            tabSalesPersons.Location = new Point(12, 69);
            tabSalesPersons.Name = "tabSalesPersons";
            tabSalesPersons.Padding = new Padding(3);
            tabSalesPersons.Size = new Size(2566, 684);
            tabSalesPersons.TabIndex = 0;
            tabSalesPersons.Text = "Sales Persons";
            tabSalesPersons.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1943, 586);
            button1.Name = "button1";
            button1.Size = new Size(295, 69);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSalesPersons
            // 
            dataGridViewSalesPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalesPersons.Location = new Point(0, 6);
            dataGridViewSalesPersons.Name = "dataGridViewSalesPersons";
            dataGridViewSalesPersons.RowHeadersWidth = 123;
            dataGridViewSalesPersons.Size = new Size(2238, 577);
            dataGridViewSalesPersons.TabIndex = 0;
            // 
            // SalesTracker
            // 
            SalesTracker.Controls.Add(tabProducts);
            SalesTracker.Controls.Add(tabSalesPersons);
            SalesTracker.Controls.Add(tabCustomers);
            SalesTracker.Controls.Add(tabSales);
            SalesTracker.Controls.Add(tabDiscount);
            SalesTracker.Controls.Add(tabCommisionReport);
            SalesTracker.Location = new Point(2, 12);
            SalesTracker.Name = "SalesTracker";
            SalesTracker.SelectedIndex = 0;
            SalesTracker.Size = new Size(2590, 765);
            SalesTracker.TabIndex = 0;
            // 
            // tabDiscount
            // 
            tabDiscount.Controls.Add(dataGridView2);
            tabDiscount.Location = new Point(12, 69);
            tabDiscount.Name = "tabDiscount";
            tabDiscount.Size = new Size(2566, 684);
            tabDiscount.TabIndex = 5;
            tabDiscount.Text = "Discount";
            tabDiscount.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 123;
            dataGridView2.Size = new Size(1371, 450);
            dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2834, 1084);
            Controls.Add(SalesTracker);
            Name = "Form1";
            Text = "SalesTracker";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabSalesPersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalesPersons).EndInit();
            SalesTracker.ResumeLayout(false);
            tabDiscount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabCommisionReport;
        private TabPage tabSales;
        private TabPage tabCustomers;
        private TabPage tabProducts;
        private TabPage tabSalesPersons;
        private DataGridView dataGridViewSalesPersons;
        private TabControl SalesTracker;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCustomer;
        private DataGridView dataGridViewSales;
        private TabPage tabDiscount;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn ProdcutName;
    }
}
