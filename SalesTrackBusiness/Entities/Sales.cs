
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTrackBusiness.Entities
{
    //-Product, Salesperson, Customer, Sales Date
    public class Sales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int SalesPersonId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal SalesPrice { get; set;}
    }
}
