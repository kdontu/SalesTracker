using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;

namespace SalesTrackBusiness.Interfaces
{
    public interface ISalesPersonManagement
    { 
        GetSalesPersonsResult GetSalesPersons();
        UpdateSalesPersonResult UpdateSalesPerson(SalesPersonDTO salesPerson);
    }
}
