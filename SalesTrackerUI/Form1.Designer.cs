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
            buttonGenerate_Report = new Button();
            comboBoxYear = new ComboBox();
            label1 = new Label();
            comboBoxQuarter = new ComboBox();
            label3 = new Label();
            comboBox_SalesPersons = new ComboBox();
            tabSales = new TabPage();
            button3 = new Button();
            dataGridViewSales = new DataGridView();
            tabCustomers = new TabPage();
            dataGridViewCustomer = new DataGridView();
            tabProducts = new TabPage();
            buttonProdcut = new Button();
            dataGridViewProducts = new DataGridView();
            tabSalesPersons = new TabPage();
            buttonSalesPersons = new Button();
            dataGridViewSalesPersons = new DataGridView();
            SalesTracker = new TabControl();
            tabDiscount = new TabPage();
            dataGridView2 = new DataGridView();
            tabCommisionReport.SuspendLayout();
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
            tabCommisionReport.Controls.Add(buttonGenerate_Report);
            tabCommisionReport.Controls.Add(comboBoxYear);
            tabCommisionReport.Controls.Add(label1);
            tabCommisionReport.Controls.Add(comboBoxQuarter);
            tabCommisionReport.Controls.Add(label3);
            tabCommisionReport.Controls.Add(comboBox_SalesPersons);
            tabCommisionReport.Location = new Point(12, 69);
            tabCommisionReport.Name = "tabCommisionReport";
            tabCommisionReport.Size = new Size(2900, 755);
            tabCommisionReport.TabIndex = 4;
            tabCommisionReport.Text = "Commission Report";
            tabCommisionReport.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate_Report
            // 
            buttonGenerate_Report.FlatStyle = FlatStyle.Flat;
            buttonGenerate_Report.Location = new Point(444, 232);
            buttonGenerate_Report.Name = "buttonGenerate_Report";
            buttonGenerate_Report.Size = new Size(295, 69);
            buttonGenerate_Report.TabIndex = 20;
            buttonGenerate_Report.Text = "Generate Report";
            buttonGenerate_Report.UseVisualStyleBackColor = true;
            buttonGenerate_Report.Click += btGenerate_Report_Click;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(458, 143);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(281, 56);
            comboBoxYear.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 151);
            label1.Name = "label1";
            label1.Size = new Size(150, 48);
            label1.TabIndex = 18;
            label1.Text = "Quarter:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBoxQuarter
            // 
            comboBoxQuarter.FormattingEnabled = true;
            comboBoxQuarter.Items.AddRange(new object[] { "Quarter1", "Quarter2", "Quarter3", "Quarter4" });
            comboBoxQuarter.Location = new Point(275, 143);
            comboBoxQuarter.Name = "comboBoxQuarter";
            comboBoxQuarter.Size = new Size(157, 56);
            comboBoxQuarter.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 52);
            label3.Name = "label3";
            label3.Size = new Size(230, 48);
            label3.TabIndex = 16;
            label3.Text = "SalesPersons:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox_SalesPersons
            // 
            comboBox_SalesPersons.FormattingEnabled = true;
            comboBox_SalesPersons.Location = new Point(275, 44);
            comboBox_SalesPersons.Name = "comboBox_SalesPersons";
            comboBox_SalesPersons.Size = new Size(464, 56);
            comboBox_SalesPersons.TabIndex = 15;
            comboBox_SalesPersons.UseWaitCursor = true;
            // 
            // tabSales
            // 
            tabSales.Controls.Add(button3);
            tabSales.Controls.Add(dataGridViewSales);
            tabSales.Location = new Point(12, 69);
            tabSales.Name = "tabSales";
            tabSales.Size = new Size(2900, 755);
            tabSales.TabIndex = 3;
            tabSales.Text = "Sales";
            tabSales.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(2513, 459);
            button3.Name = "button3";
            button3.Size = new Size(295, 69);
            button3.TabIndex = 2;
            button3.Text = "Create Sale";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CreateSale_Click;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(3, 3);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 123;
            dataGridViewSales.Size = new Size(2805, 450);
            dataGridViewSales.TabIndex = 0;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(dataGridViewCustomer);
            tabCustomers.Location = new Point(12, 69);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(2900, 755);
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
            dataGridViewCustomer.Size = new Size(2865, 450);
            dataGridViewCustomer.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(buttonProdcut);
            tabProducts.Controls.Add(dataGridViewProducts);
            tabProducts.Location = new Point(12, 69);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(2900, 755);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // buttonProdcut
            // 
            buttonProdcut.FlatStyle = FlatStyle.Flat;
            buttonProdcut.Location = new Point(2265, 480);
            buttonProdcut.Name = "buttonProdcut";
            buttonProdcut.Size = new Size(295, 69);
            buttonProdcut.TabIndex = 2;
            buttonProdcut.Text = "Update";
            buttonProdcut.UseVisualStyleBackColor = true;
            buttonProdcut.Click += UpdateProduct_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(-12, 6);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 123;
            dataGridViewProducts.Size = new Size(2801, 450);
            dataGridViewProducts.TabIndex = 0;
            // 
            // tabSalesPersons
            // 
            tabSalesPersons.Controls.Add(buttonSalesPersons);
            tabSalesPersons.Controls.Add(dataGridViewSalesPersons);
            tabSalesPersons.Location = new Point(12, 69);
            tabSalesPersons.Name = "tabSalesPersons";
            tabSalesPersons.Padding = new Padding(3);
            tabSalesPersons.Size = new Size(2900, 755);
            tabSalesPersons.TabIndex = 0;
            tabSalesPersons.Text = "Sales Persons";
            tabSalesPersons.UseVisualStyleBackColor = true;
            // 
            // buttonSalesPersons
            // 
            buttonSalesPersons.FlatStyle = FlatStyle.Flat;
            buttonSalesPersons.Location = new Point(2513, 589);
            buttonSalesPersons.Name = "buttonSalesPersons";
            buttonSalesPersons.Size = new Size(295, 69);
            buttonSalesPersons.TabIndex = 1;
            buttonSalesPersons.Text = "Update";
            buttonSalesPersons.UseVisualStyleBackColor = true;
            buttonSalesPersons.Click += UpdateSalesPerson_Click;
            // 
            // dataGridViewSalesPersons
            // 
            dataGridViewSalesPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalesPersons.Location = new Point(0, 6);
            dataGridViewSalesPersons.Name = "dataGridViewSalesPersons";
            dataGridViewSalesPersons.RowHeadersWidth = 123;
            dataGridViewSalesPersons.Size = new Size(2808, 577);
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
            SalesTracker.Size = new Size(2924, 836);
            SalesTracker.TabIndex = 0;
            // 
            // tabDiscount
            // 
            tabDiscount.Controls.Add(dataGridView2);
            tabDiscount.Location = new Point(12, 69);
            tabDiscount.Name = "tabDiscount";
            tabDiscount.Size = new Size(2900, 755);
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
            dataGridView2.Size = new Size(2838, 450);
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
            tabCommisionReport.ResumeLayout(false);
            tabCommisionReport.PerformLayout();
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
        private Button buttonProdcut;
        private Button buttonSalesPersons;
        private DataGridViewTextBoxColumn ProdcutName;
        private ComboBox comboBoxYear;
        private Label label1;
        private ComboBox comboBoxQuarter;
        private Label label3;
        private ComboBox comboBox_SalesPersons;
        private Button buttonGenerate_Report;
    }
}
