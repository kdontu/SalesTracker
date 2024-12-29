using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Entities;

namespace SalesTrackBusiness
{
    public class CustomerManagement : ICustomerManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();

        public List<CustomerDTO> GetCustomers()
        {
            List<CustomerDTO> customerDTOList = new List<CustomerDTO>();

            try
            {
                foreach (Customer customer in _salesTrackerContext.Customers)
                {
                    CustomerDTO customerDTO = new CustomerDTO();
                    customerDTO.FirstName = customer.FirstName;
                    customerDTO.LastName = customer.LastName;
                    customerDTO.Phone = customer.Phone;
                    customerDTO.Address = customer.Address;
                    customerDTOList.Add(customerDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return customerDTOList;
        }
    }
}
