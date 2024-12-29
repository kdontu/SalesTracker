namespace SalesTrackBusiness.Entities
{
    //– SalesPersonId, First Name, Last Name, Address, Phone, Start Date, Termination Date, Manager
    public class SalesPerson
    {
        public int SalesPersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? TerminationDate { get; set; } = DateTime.MaxValue;
        public string? Manager { get; set; }
        public  decimal Commission { get; set; }
        public virtual ICollection<Sales> Sales { get; set; } = new List<Sales>();
        public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>(); 
    }
}
