
using SalesTrackBusiness;
using SalesTrackCommon.Entities;
using SalesTrackBusiness.Interfaces;

namespace SalesTrackData
{
    public class SalesTrackUIService : ISalesTrackBusiness
    {
        private readonly IDbManagement _dbManagement = new DbManagement();
        private readonly ICustomerManagement _customerManagement = new CustomerManagement();
        private readonly IProductsManagement _productsManagement = new ProductsManagement();
        private readonly ISalesManagement _salesManagement = new SalesManagement();
        private readonly ISalesPersonManagement _salesPersonManagement = new SalesPersonManagement();
        private readonly IDiscountManagement _discountManagement = new DiscountManagement();

        public SalesTrackUIService()
        {           
        }

        public void Initialize()
        {
            _dbManagement.InitializeDb();
        }
        public void UnInitialize()
        {
            _dbManagement.UnInitializeDb();
        }
        public List<SalesPersonDTO> GetSalesPersons()
        {
            return _salesPersonManagement.GetSalesPersons();
        }
        public SalesPersonDTO UpdateSalesPerson(SalesPersonDTO salesPerson)
        {
            return _salesPersonManagement.UpdateSalesPerson(salesPerson);
        }

        public List<ProductDTO> GetProducts()
        {
            return _productsManagement.GetProducts();
        }
        public ProductDTO UpdateProduct(ProductDTO salesPerson)
        {
            return _productsManagement.UpdateProduct(salesPerson);
        }

        public List<SalesDTO> GetSales()
        {
            return _salesManagement.GetSales();
        }

        public SalesDTO CreateSale(SalesDTO salesPerson)
        {
            return _salesManagement.CreateSales(salesPerson);
        }
        public List<CustomerDTO> GetCustomers()
        {
            return _customerManagement.GetCustomers();
        }
        public List<DiscountDTO> GetDiscounts()
        {
            return _discountManagement.GetDiscounts();
        }
        public List<SalesPersonCommissionReportDTO> GetSalesPersonCommissionReport()
        {
            throw new System.NotImplementedException();
        }
    }
}
