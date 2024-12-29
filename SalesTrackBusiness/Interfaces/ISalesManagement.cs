using SalesTrackCommon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SalesTrackBusiness.Interfaces
{
    public interface ISalesManagement
    {
        public List<SalesDTO> GetSales();
        public SalesDTO CreateSales(SalesDTO sales);
    }
}
