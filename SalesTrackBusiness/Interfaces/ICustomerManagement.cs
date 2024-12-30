using SalesTrackCommon.Models.Results;

namespace SalesTrackBusiness.Interfaces
{
    public interface ICustomerManagement
    {
        GetCustomersResult GetCustomers();
    }
}
