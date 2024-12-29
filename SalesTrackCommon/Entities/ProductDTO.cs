using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SalesTrackCommon.Entities
{
    public class ProductDTO
    {
        public ProductDTO() { }

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public string? Description { get; set; } = null;
        public string? Style { get; set; }
        public string? PurchasePrice { get; set; }
        public string SalePrice { get; set; }
        public string QtyOnHand { get; set; }
        public string CommissionPercentage { get; set; }
    }
}
