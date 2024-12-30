using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;
using SalesTrackBusiness.Interfaces;

namespace SalesTrackBusiness.Interfaces
{
    public interface ISalesManagement
    {
        GetSalesResult GetSales();
        CreateSaleResult CreateSale(SalesDTO sales);
    }
}
