using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;

namespace SalesTrackBusiness
{
    public class SalesManagement : ISalesManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public GetSalesResult GetSales()
        {
            GetSalesResult getSalesResult = new GetSalesResult();

            try
            {
                List<SalesDTO> salesDTOList = new List<SalesDTO>();

                foreach (Sales sales in _salesTrackerContext.Sales)
                {
                    SalesDTO salesDTO = new SalesDTO();
                    salesDTO.SalesId = sales.SalesId;
                    salesDTO.SalesPersonId = sales.SalesPersonId;
                    salesDTO.ProductId = sales.ProductId;
                    salesDTO.CustomerId = sales.CustomerId;
                    salesDTO.SalesDate = sales.SalesDate;
                    salesDTO.SalesPrice = sales.SalesPrice;
                    salesDTOList.Add(salesDTO);
                }
                getSalesResult.Sales = salesDTOList;
                getSalesResult.ResponseMessage = "Sales retrieved successfully";
                getSalesResult.HasErrors = false;
            }
            catch (Exception ex)
            {
                getSalesResult.ResponseMessage = ex.Message;
                getSalesResult.HasErrors = false;
                return getSalesResult;
            }

            return getSalesResult;
        }
        public CreateSaleResult CreateSale(SalesDTO salesDTO)
        {
            CreateSaleResult createSaleResult = new CreateSaleResult();

            try
            {
                var salesDTONew = new SalesDTO();

                Sales saleObj = new Sales();

                saleObj.SalesPersonId = salesDTO.SalesPersonId;
                saleObj.ProductId = salesDTO.ProductId;
                saleObj.CustomerId = salesDTO.CustomerId;
                saleObj.SalesDate = salesDTO.SalesDate;
                
                // Calculate Sale Price from the product definition
                Product product = new Product();
                product = _salesTrackerContext.Products.Where(x => x.ProductId == saleObj.ProductId).FirstOrDefault();
                if ((product != null) && (product.QtyOnHand < 0))
                {
                    createSaleResult.ResponseMessage = string.Format("Product {0} is out of stock", product.Name );
                    createSaleResult.HasErrors = true;
                    return createSaleResult;
                }
                Discount discount = _salesTrackerContext.Discounts.Where(x => x.ProductId == product.ProductId).FirstOrDefault();
                if ((discount != null) && (DateTime.Now.Date >= discount.BeginDate) && (DateTime.Now.Date <= discount.EndDate))
                {
                    saleObj.SalesPrice = product.SalePrice - product.SalePrice * discount.DiscountPercentage;

                }
                else
                    saleObj.SalesPrice = product.SalePrice;

                SalesPerson SalesPerson = new SalesPerson();
                SalesPerson = _salesTrackerContext.SalesPersons.Where(x => x.SalesPersonId == saleObj.SalesPersonId).FirstOrDefault();
                // Calculate commission for the sales person
                SalesPerson.Commission += Convert.ToDecimal(Convert.ToInt64(saleObj.SalesPrice) * Convert.ToInt64(product.CommissionPercentage) * 0.01);

                _salesTrackerContext.Update(SalesPerson);
                //_salesTrackerContext.SaveChanges();

                // Reduce product quantity by 1
                product.QtyOnHand -= 1;
                _salesTrackerContext.Update(product);
                //_salesTrackerContext.SaveChanges();

                _salesTrackerContext.Sales.Add(saleObj);
                _salesTrackerContext.SaveChanges();

                saleObj = _salesTrackerContext.Sales.Where(x => x.ProductId == saleObj.ProductId).FirstOrDefault();

                salesDTONew.SalesId = saleObj.SalesId;
                salesDTONew.SalesPersonId = saleObj.SalesPersonId;
                salesDTONew.ProductId = saleObj.ProductId;
                salesDTONew.CustomerId = saleObj.CustomerId;
                salesDTONew.SalesDate = saleObj.SalesDate;
                salesDTONew.SalesPrice = saleObj.SalesPrice;
            }
            catch (Exception ex)
            {
                createSaleResult.ResponseMessage = string.Format("Product {0} is out of stock", salesDTO.ProductId);
                createSaleResult.HasErrors = true;
                return createSaleResult;
            }
            return createSaleResult;
        }
    }
}
