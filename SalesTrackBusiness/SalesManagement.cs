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
                if (product.QtyOnHand < 0)
                {
                    salesDTONew.ResponseMessage = string.Format("Product {0} is out of stock", product.Name );
                    salesDTONew.HasErrors = true;
                    return salesDTONew;
                }
                Discount discount = _salesTrackerContext.Discounts.Where(x => x.ProductId == product.ProductId).FirstOrDefault();
                if ((discount != null) && (DateTime.Now.Date >= discount.BeginDate) && (DateTime.Now.Date <= discount.EndDate))
                {
                    sales.SalesPrice = product.SalePrice - product.SalePrice * discount.DiscountPercentage;

                }
                else
                    sales.SalesPrice = product.SalePrice;

                SalesPerson SalesPerson = new SalesPerson();
                SalesPerson = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == sales.SalesPersonId).FirstOrDefault();
                // Calculate commission for the sales person
                SalesPerson.Commission += Convert.ToDecimal(Convert.ToInt64(sales.SalesPrice) * Convert.ToInt64(product.CommissionPercentage) * 0.01);

                _salesTrackerContext.Update(SalesPerson);
                _salesTrackerContext.SaveChanges();

                // Reduce product quantity by 1
                product.QtyOnHand -= 1;
                _salesTrackerContext.Update(product);
                _salesTrackerContext.SaveChanges();

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
                salesDTONew.HasErrors = true;
                salesDTONew.ResponseMessage = ex.Message;
                return salesDTONew;
            }
            return salesDTONew;
        }
    }
}
