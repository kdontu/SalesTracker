using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;


namespace SalesTrackBusiness
{
    public class SalesPersonManagement : ISalesPersonManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public GetSalesPersonsResult GetSalesPersons()
        {
            GetSalesPersonsResult getSalesPersonsResult = new GetSalesPersonsResult();
          
            try
            {
                List<SalesPersonDTO> salesPersonDTOList = new List<SalesPersonDTO>();

                foreach (SalesPerson salesPerson in _salesTrackerContext.SalesPersons)
                {
                    SalesPersonDTO salesPersonDTO = new SalesPersonDTO();
                    salesPersonDTO.SalesPersonId= salesPerson.SalesPersonId;
                    salesPersonDTO.FirstName = salesPerson.FirstName;
                    salesPersonDTO.LastName = salesPerson.LastName;
                    salesPersonDTO.Address = salesPerson.Address;
                    salesPersonDTO.Phone = salesPerson.Phone;
                    salesPersonDTO.Manager = salesPerson.Manager;
                    salesPersonDTO.TerminationDate = salesPerson.TerminationDate;
                    salesPersonDTO.StartDate = salesPerson.StartDate;
                    salesPersonDTO.Commission = salesPerson.Commission;
                    salesPersonDTOList.Add(salesPersonDTO);
                }
                getSalesPersonsResult.SalesPersons = salesPersonDTOList;
                getSalesPersonsResult.ResponseMessage = "Sales Persons retrieved successfully";
                getSalesPersonsResult.HasErrors = false;
            }
            catch (Exception ex)
            {
                getSalesPersonsResult.ResponseMessage = ex.Message;
                getSalesPersonsResult.HasErrors = true;
                return getSalesPersonsResult;
            }

            return getSalesPersonsResult;
        }

        public UpdateSalesPersonResult UpdateSalesPerson(SalesPersonDTO salesDTOPerson)
        {
            UpdateSalesPersonResult updateSalesPersonResult = new UpdateSalesPersonResult();
            
            try
            {
                SalesPersonDTO salesPersonDTOChanged = new SalesPersonDTO();

                SalesPerson salesPerson = new SalesPerson();
                salesPerson.SalesPersonId = salesDTOPerson.SalesPersonId;
                salesPerson.FirstName = salesDTOPerson.FirstName;
                salesPerson.LastName = salesDTOPerson.LastName;
                salesPerson.Address = salesDTOPerson.Address;
                salesPerson.Phone = salesDTOPerson.Phone;
                salesPerson.Manager = salesDTOPerson.Manager;
                salesPerson.TerminationDate = salesDTOPerson.TerminationDate;
                salesPerson.Commission = salesDTOPerson.Commission;
                salesPerson.StartDate = salesDTOPerson.StartDate;
              

                var salesPersonToChange = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == salesPerson.SalesPersonId).FirstOrDefault();
                salesPersonToChange = salesPerson;
                _salesTrackerContext.SalesPersons.Update(salesPersonToChange);

                _salesTrackerContext.SaveChanges();
           
                var salesPersonChanged = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == salesPerson.SalesPersonId).FirstOrDefault();
                salesPersonDTOChanged.SalesPersonId = salesPersonChanged.SalesPersonId;
                salesPersonDTOChanged.FirstName = salesPersonChanged.FirstName;
                salesPersonDTOChanged.LastName = salesPersonChanged.LastName;
                salesPersonDTOChanged.Address = salesPersonChanged.Address;
                salesPersonDTOChanged.Phone = salesPersonChanged.Phone;
                salesPersonDTOChanged.Manager = salesPersonChanged.Manager;
                salesPersonDTOChanged.TerminationDate = salesPersonChanged.TerminationDate;
                salesPersonDTOChanged.Commission = salesPersonChanged.Commission;
                salesPersonDTOChanged.StartDate = salesPersonChanged.StartDate;

                updateSalesPersonResult.SalesPerson = salesPersonDTOChanged;
                updateSalesPersonResult.ResponseMessage = "Sales Person updated successfully";
                updateSalesPersonResult.HasErrors = false;
            }
            catch (Exception ex)
            {
                updateSalesPersonResult.ResponseMessage = ex.Message;
                updateSalesPersonResult.HasErrors = true;
                return updateSalesPersonResult;
            }
            return updateSalesPersonResult;
        }

    }
}
