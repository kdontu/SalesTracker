namespace SalesTrackBusiness.Entities
{
    public class Product
    {
        //– Name, Manufacturer, Style, Purchase Price, Sale Price, Qty On Hand, Commission Percentage
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public string? Description { get; set; }
        public string? Style { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int QtyOnHand { get; set; }
        public decimal CommissionPercentage { get; set; }
    }
}
