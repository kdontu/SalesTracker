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
                var SalesPersonToChange = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == salesDTOPerson.SalesPersonId).FirstOrDefault();
                SalesPersonToChange.FirstName = salesDTOPerson.FirstName;
                SalesPersonToChange.LastName = salesDTOPerson.LastName;
                SalesPersonToChange.Address = salesDTOPerson.Address;
                SalesPersonToChange.Phone = salesDTOPerson.Phone;
                SalesPersonToChange.Manager = salesDTOPerson.Manager;
                SalesPersonToChange.TerminationDate = salesDTOPerson.TerminationDate;
                SalesPersonToChange.Commission = salesDTOPerson.Commission;
                SalesPersonToChange.StartDate = salesDTOPerson.StartDate;
              
                 _salesTrackerContext.SalesPersons.Update(SalesPersonToChange);

                _salesTrackerContext.SaveChanges();

                SalesPersonDTO salesPersonDTOChanged = new SalesPersonDTO();
                var salesPersonChanged = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == SalesPersonToChange.SalesPersonId).FirstOrDefault();
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
