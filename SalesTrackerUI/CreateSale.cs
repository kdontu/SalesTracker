using SalesTrackCommon.Entities;
using SalesTrackData;
using SalesTrackBusiness.Entities;


namespace SalesTrackerUI
{
    public partial class CreateSale : Form
    {
        public CreateSale()
        {
            InitializeComponent();
        }

        public ISalesTrackBusiness salesTrackBusiness;

        private void button2_Click(object sender, EventArgs e)
        {
            //need to work on this
            try
            {

                /*SalesDTO sale = new SalesDTO
                {
                    SalesId = Convert.ToInt32(((SalesPerson)this.comboBox_SalesPersons.SelectedItem).SalesPersonId),

                    ProductId = Convert.ToInt32(((Product)this.comboBox_Products.SelectedItem).ProductId)
                    //SalesPersonId = Convert.ToInt32(((SalesPerson)this.comboBox_SalesPersons.SelectedItem).SalesPersonId,

                    //CustomerId = (Convert.ToInt32(((Customer)this.comboBox_SalesPersons.SelectedItem).CustomerId),
                    //SalesDate = Convert.ToDateTime(this.txtSaleDate.ToString()),
                    //SalesPrice = Convert.ToDecimal(((SalesPerson)comboBox_SalesPersons.SelectedItem))
                };*/
                SalesDTO sale = new SalesDTO();
                sale.ProductId = ((Product)comboBox_Products.SelectedItem).ProductId;
                sale.CustomerId = ((Customer)comboBox_Customers.SelectedItem).CustomerId;
                sale.SalesDate = Convert.ToDateTime(txtSaleDate.Text);
                sale.SalesPersonId = Convert.ToInt32(((SalesPerson)this.comboBox_SalesPersons.SelectedItem).SalesPersonId);
                //SalesPrice = Convert.ToDecimal(((SalesPerson)comboBox_SalesPersons.SelectedItem))
                salesTrackBusiness.CreateSale(sale);
                var sales = salesTrackBusiness.GetSales();
                // dataGridViewProducts.DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void CreateSale_Load(object sender, EventArgs e)
        {
            try
            {
                var products = salesTrackBusiness.GetProducts();
                comboBox_Products.DataSource = products;
                comboBox_SalesPersons.DataSource = salesTrackBusiness.GetSalesPersons();
                comboBox_Customers.DataSource = salesTrackBusiness.GetCustomers();
                txtSaleDate.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

