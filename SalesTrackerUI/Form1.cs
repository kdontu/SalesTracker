using SalesTrackData;
using SalesTrackCommon.Entities;
using SalesTrackBusiness.Entities;
using SalesTrackerUI;

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
            products = salesTrackBusiness.GetProducts();
            dataGridViewProducts.DataSource = products;
            dataGridViewCustomer.DataSource = salesTrackBusiness.GetCustomers();
            dataGridViewSales.DataSource = salesTrackBusiness.GetSales();
            dataGridViewSalesPersons.DataSource = salesTrackBusiness.GetSalesPersons();
            dataGridView2.DataSource = salesTrackBusiness.GetDiscounts();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            salesTrackBusiness.UnInitialize();
        }

        private void button2_Click(object sender, EventArgs e)
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
                salesTrackBusiness.UpdateProduct(product);
                products = salesTrackBusiness.GetProducts();
                dataGridViewProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                salesTrackBusiness.UpdateSalesPerson(salesPerson);
                var salesPersons = salesTrackBusiness.GetSalesPersons();
                dataGridViewProducts.DataSource = salesPersons;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //need to work on this
            try
            {
                CreateSale sale = new CreateSale();
                sale.salesTrackBusiness = salesTrackBusiness;
                sale.Show();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
