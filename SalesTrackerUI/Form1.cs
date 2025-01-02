using SalesTrackData;
using SalesTrackCommon.Models;
using SalesTrackBusiness.Entities;
using SalesTrackerUI;
using SalesTrackCommon.Models.Results;

namespace SalesTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ISalesTrackBusiness salesTrackBusiness;
        List<ProductDTO> products;
        private void Form1_Load(object sender, EventArgs e)
        {
            salesTrackBusiness = new SalesTrackUIService();
            salesTrackBusiness.Initialize();
            RefreshDataGrid();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            salesTrackBusiness.UnInitialize();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDTO product = new ProductDTO
                {
                    ProductId = (int)dataGridViewProducts.CurrentRow.Cells["ProductId"].Value,
                    Name = (string)dataGridViewProducts.CurrentRow.Cells["Name"].Value,
                    Manufacturer = (string)dataGridViewProducts.CurrentRow.Cells["Manufacturer"].Value,
                    Style = (string)dataGridViewProducts.CurrentRow.Cells["Style"].Value,
                    PurchasePrice = (string)dataGridViewProducts.CurrentRow.Cells["PurchasePrice"].Value,
                    SalePrice = (string)dataGridViewProducts.CurrentRow.Cells["SalePrice"].Value,
                    QtyOnHand = (string)dataGridViewProducts.CurrentRow.Cells["QtyOnHand"].Value,
                    CommissionPercentage = (string)dataGridViewProducts.CurrentRow.Cells["CommissionPercentage"].Value
                };
                UpdateProductResult updateProductResult = salesTrackBusiness.UpdateProduct(product);
                if (!updateProductResult.HasErrors)
                {
                    GetProductsResult productsResult = salesTrackBusiness.GetProducts();
                    if (!productsResult.HasErrors)
                        dataGridViewProducts.DataSource = products;
                    else
                    {
                        MessageBox.Show(productsResult.ResponseMessage);
                    }
                }
                else
                {
                    MessageBox.Show(updateProductResult.ResponseMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateSalesPerson_Click(object sender, EventArgs e)
        {
            try
            {
                SalesPersonDTO salesPerson = new SalesPersonDTO
                {
                    SalesPersonId = Convert.ToInt32(this.dataGridViewSalesPersons.CurrentRow.Cells["SalesPersonId"].Value.ToString()),
                    FirstName = this.dataGridViewSalesPersons.CurrentRow.Cells["FirstName"].Value.ToString(),
                    LastName = this.dataGridViewSalesPersons.CurrentRow.Cells["LastName"].Value.ToString(),
                    Address = this.dataGridViewSalesPersons.CurrentRow.Cells["Address"].Value.ToString(),
                    Phone = this.dataGridViewSalesPersons.CurrentRow.Cells["Phone"].Value.ToString(),
                    Manager = this.dataGridViewSalesPersons.CurrentRow.Cells["Manager"].Value.ToString(),
                    TerminationDate = Convert.ToDateTime(this.dataGridViewSalesPersons.CurrentRow.Cells["TerminationDate"].Value.ToString()),
                    StartDate = Convert.ToDateTime(this.dataGridViewSalesPersons.CurrentRow.Cells["StartDate"].Value.ToString()),
                    Commission = Convert.ToDecimal(this.dataGridViewSalesPersons.CurrentRow.Cells["Commission"].Value.ToString())
                };
                UpdateSalesPersonResult updateSalesPerson = salesTrackBusiness.UpdateSalesPerson(salesPerson);
                if (!updateSalesPerson.HasErrors)
                {
                    GetSalesPersonsResult salesPersonsResult = salesTrackBusiness.GetSalesPersons();
                    if (!salesPersonsResult.HasErrors)
                        dataGridViewSalesPersons.DataSource = salesPersonsResult.SalesPersons;
                    else
                    {
                        MessageBox.Show(salesPersonsResult.ResponseMessage);
                    }
                }
                else
                {
                    MessageBox.Show(updateSalesPerson.ResponseMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateSale_Click(object sender, EventArgs e)
        {
            try
            {
                CreateSaleForm sale = new CreateSaleForm(this, salesTrackBusiness);
                sale.salesTrackBusiness = salesTrackBusiness;
                sale.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void RefreshDataGrid()
        {
            GetProductsResult productsResult = salesTrackBusiness.GetProducts();
            if (!productsResult.HasErrors)
            {
                products = productsResult.Products;
                dataGridViewProducts.DataSource = products;
            }
            else
            {
                MessageBox.Show(productsResult.ResponseMessage);
            }
            GetCustomersResult customersResult = salesTrackBusiness.GetCustomers();
            if (!customersResult.HasErrors)
            {
                dataGridViewCustomer.DataSource = customersResult.Customers;
            }
            else
            {
                MessageBox.Show(customersResult.ResponseMessage);
            }
            GetSalesResult getSalesResult = salesTrackBusiness.GetSales();
            if (!getSalesResult.HasErrors)
                dataGridViewSales.DataSource = getSalesResult.Sales;
            else
            {
                MessageBox.Show(getSalesResult.ResponseMessage);
            }
            GetSalesPersonsResult salesPersonsResult = salesTrackBusiness.GetSalesPersons();
            if (!salesPersonsResult.HasErrors)
                dataGridViewSalesPersons.DataSource = salesPersonsResult.SalesPersons;
            else
            {
                MessageBox.Show(salesPersonsResult.ResponseMessage);
            }

            GetDiscountsResult discountsResult = salesTrackBusiness.GetDiscounts();
            if (!discountsResult.HasErrors)
                dataGridView2.DataSource = discountsResult.Discounts;
            else
            {
                MessageBox.Show(discountsResult.ResponseMessage);
            }
            if (!salesPersonsResult.HasErrors)
                comboBox_SalesPersons.DataSource = salesPersonsResult.SalesPersons;
            else
            {
                MessageBox.Show(salesPersonsResult.ResponseMessage);
            }
        
            comboBoxYear.DataSource = Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList();
        }

        private void btGenerate_Report_Click(object sender, EventArgs e)
        {
            try
            {
                GetSalesPersonCommissionReportResult result = new GetSalesPersonCommissionReportResult();
                
                switch (comboBoxQuarter.SelectedIndex)
                {
                    case 0:
                        result = salesTrackBusiness.GetSalesPersonCommissionReport(new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 1, 1), new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 3, 31));
                        break;
                    case 1:
                        result = salesTrackBusiness.GetSalesPersonCommissionReport(new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 4, 1), new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 6, 30));
                        break;
                    case 2:
                        result = salesTrackBusiness.GetSalesPersonCommissionReport(new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 7, 1), new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 9, 30));
                        break;
                    case 3:
                        result = salesTrackBusiness.GetSalesPersonCommissionReport(new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 10, 1), new DateTime(Convert.ToInt32(comboBoxYear.SelectedItem), 12, 31));
                        break;

                }   
                if(!result.HasErrors)
                {
                    GenerateCommissionReportForm commissionForm = new GenerateCommissionReportForm(salesTrackBusiness, result.salesPersonCommissionReport);
                    commissionForm.SalesTrackBusiness = salesTrackBusiness;
                    commissionForm.Show();
                }
                else
                {
                    MessageBox.Show(result.ResponseMessage);
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
