using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackCommon.Entities;

namespace SalesTrackData
{
    public interface ISalesTrackBusiness
    {
        void Initialize();
        void UnInitialize();
        List<SalesPersonDTO> GetSalesPersons();
        SalesPersonDTO UpdateSalesPerson(SalesPersonDTO salesPerson); 
        List<ProductDTO> GetProducts();
        ProductDTO UpdateProduct(ProductDTO salesPerson);
        List<SalesDTO> GetSales();
        SalesDTO CreateSale(SalesDTO salesPerson);
        List<CustomerDTO> GetCustomers();
        List<DiscountDTO> GetDiscounts();
        List<SalesPersonCommissionReportDTO> GetSalesPersonCommissionReport();
    }
}
