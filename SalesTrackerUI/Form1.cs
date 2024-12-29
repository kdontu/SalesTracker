using SalesTrackData;
using SalesTrackCommon.Entities;

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
    }
}
