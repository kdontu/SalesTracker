using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTrackCommon.Entities
{
    public class SalesPersonDTO
    {
        public int SalesPersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? TerminationDate { get; set; } = DateTime.MaxValue;
        public string? Manager { get; set; }
        public decimal Commission { get; set; }
    }
}
