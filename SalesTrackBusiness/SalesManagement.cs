using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Entities;

namespace SalesTrackBusiness
{
    public class SalesManagement : ISalesManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public List<SalesDTO> GetSales()
        {
            List<SalesDTO> salesDTOList = new List<SalesDTO>();

            try
            {
                foreach (Sales sales in _salesTrackerContext.Sales)
                {
                    SalesDTO salesDTO = new SalesDTO();
                    salesDTO.SalesPersonId = sales.SalesPersonId;
                    salesDTO.ProductId = sales.ProductId;
                    salesDTO.CustomerId = sales.CustomerId;
                    salesDTO.SalesDate = sales.SalesDate;
                    salesDTO.SalesPrice = sales.SalesPrice;
                    salesDTOList.Add(salesDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return salesDTOList;
        }
        public SalesDTO CreateSales(SalesDTO salesDTO)
        {
            var salesDTONew = new SalesDTO();
            try
            { 
                Sales sales = new Sales();
                sales.SalesPersonId = salesDTO.SalesPersonId;
                sales.ProductId = salesDTO.ProductId;
                sales.CustomerId = salesDTO.CustomerId;
                sales.SalesDate = salesDTO.SalesDate;
                sales.SalesPrice = salesDTO.SalesPrice;

                // Calculate Sale Price from the product definition
                Product product = new Product();
                product = _salesTrackerContext.Products.Where(x => x.ProductId == sales.ProductId).FirstOrDefault();

                // Calculate discount TODO
                sales.SalesPrice = product.SalePrice;

                SalesPerson SalesPerson = new SalesPerson();
                SalesPerson = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == sales.SalesPersonId).FirstOrDefault();
                // Calculate commission for the sales person
                SalesPerson.Commission += Convert.ToDecimal(Convert.ToInt64(sales.SalesPrice) * Convert.ToInt64(product.CommissionPercentage) * 0.01);

                // Reduce product quantity by 1
                product.QtyOnHand -= 1;

                _salesTrackerContext.Sales.Add(sales);
                _salesTrackerContext.SaveChanges();

                sales = _salesTrackerContext.Sales.Where(x => x.SalesId == sales.SalesId).FirstOrDefault();

                salesDTONew.SalesId = sales.SalesId;
                salesDTONew.SalesPersonId = sales.SalesPersonId;
                salesDTONew.ProductId = sales.ProductId;
                salesDTONew.CustomerId = sales.CustomerId;
                salesDTONew.SalesDate = sales.SalesDate; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return (salesDTONew);
        }
    }
}
