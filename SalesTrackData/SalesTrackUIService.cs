
using SalesTrackBusiness;
using SalesTrackCommon.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;

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
        private readonly ISalesPersonCommissionReportManagement _salesPersonCommissionManagement = new SalesPersonCommissionReportManagement();
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
        public GetSalesPersonsResult GetSalesPersons()
        {
            return _salesPersonManagement.GetSalesPersons();
        }
        public UpdateSalesPersonResult UpdateSalesPerson(SalesPersonDTO salesPerson)
        {
            return _salesPersonManagement.UpdateSalesPerson(salesPerson);
        }

        public GetProductsResult GetProducts()
        {
            return _productsManagement.GetProducts();
        }
        public UpdateProductResult UpdateProduct(ProductDTO salesPerson)
        {
            return _productsManagement.UpdateProduct(salesPerson);
        }

        public GetSalesResult GetSales()
        {
            return _salesManagement.GetSales();
        }

        public CreateSaleResult CreateSale(SalesDTO salesPerson)
        {
            return _salesManagement.CreateSale(salesPerson);
        }
        public GetCustomersResult GetCustomers()
        {
            return _customerManagement.GetCustomers();
        }
        public GetDiscountsResult GetDiscounts()
        {
            return _discountManagement.GetDiscounts();
        }
        public GetSalesPersonCommissionReportResult GetSalesPersonCommissionReport(DateTime quarterStart, DateTime quarterEnd)
        {
            return _salesPersonCommissionManagement.GetSalesPersonCommissionReport(quarterStart, quarterEnd);
        }
    }
}
