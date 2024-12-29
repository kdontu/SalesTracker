using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTrackCommon.Entities
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public virtual ICollection<SalesDTO> Sales { get; set; } = new List<SalesDTO>();
        public virtual ICollection<DiscountDTO> Discounts { get; set; } = new List<DiscountDTO>();
    }
}
