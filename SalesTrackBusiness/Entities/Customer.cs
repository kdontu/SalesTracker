using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTrackBusiness.Entities
{
    public class Customer
    {   
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public virtual ICollection<Sales> Sales { get; set; } = new List<Sales>();
        public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();
        
    }
}
