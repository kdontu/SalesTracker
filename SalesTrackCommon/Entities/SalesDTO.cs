using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTrackCommon.Entities
{
    public class SalesDTO : BaseDTO
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int SalesPersonId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal SalesPrice { get; set; }
    }
}
