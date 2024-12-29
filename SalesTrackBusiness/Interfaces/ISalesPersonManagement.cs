using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackCommon.Entities;

namespace SalesTrackBusiness.Interfaces
{
    public interface ISalesPersonManagement
    { 
        List<SalesPersonDTO> GetSalesPersons();
        SalesPersonDTO UpdateSalesPerson(SalesPersonDTO salesPerson);
    }
}
