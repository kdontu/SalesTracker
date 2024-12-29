using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTrackBusiness.Entities
{
    //-Product, Salesperson, Customer, Sales Date
    public class Sales
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int SalesPersonId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal SalesPrice { get; set;}
    }
}
