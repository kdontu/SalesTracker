using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;

namespace SalesTrackBusiness
{
    public class CustomerManagement : ICustomerManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();

        public GetCustomersResult GetCustomers()
        {
            GetCustomersResult customersResult = new GetCustomersResult();
            try
            {
                List<CustomerDTO> customerDTOList = new List<CustomerDTO>();

                foreach (Customer customer in _salesTrackerContext.Customers)
                {
                    CustomerDTO customerDTO = new CustomerDTO();
                    customerDTO.CustomerId = customer.CustomerId;
                    customerDTO.FirstName = customer.FirstName;
                    customerDTO.LastName = customer.LastName;
                    customerDTO.Phone = customer.Phone;
                    customerDTO.Address = customer.Address;
                    customerDTOList.Add(customerDTO);
                }
                customersResult.Customers = customerDTOList;
                customersResult.ResponseMessage = "Success";
                customersResult.HasErrors = false;

            }
            catch (Exception ex)
            {
                customersResult.ResponseMessage = ex.Message;
                customersResult.HasErrors = true;
                return customersResult;
            }
            return customersResult;
        }
    }
}
