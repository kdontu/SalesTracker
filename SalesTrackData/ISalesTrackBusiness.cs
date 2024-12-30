using SalesTrackCommon.Entities;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;

namespace SalesTrackData
{
    public interface ISalesTrackBusiness
    {
        void Initialize();
        void UnInitialize();
        GetSalesPersonsResult GetSalesPersons();
        UpdateSalesPersonResult UpdateSalesPerson(SalesPersonDTO salesPerson);
        GetProductsResult GetProducts();
        UpdateProductResult UpdateProduct(ProductDTO salesPerson);
        GetSalesResult GetSales();
        CreateSaleResult CreateSale(SalesDTO salesPerson);
        GetCustomersResult GetCustomers();
        GetDiscountsResult GetDiscounts();
        GetSalesPersonCommissionReportResult GetSalesPersonCommissionReport();
    }
}
