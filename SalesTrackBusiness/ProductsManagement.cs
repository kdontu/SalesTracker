using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;
using SalesTrackBusiness.Entities;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;
using SalesTrackBusiness.Interfaces;

namespace SalesTrackBusiness
{
    public class ProductsManagement : IProductsManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public GetProductsResult GetProducts()
        {
            GetProductsResult getProductsResult = new GetProductsResult();       
            
            try
            {
                List<ProductDTO> productDTOList = new List<ProductDTO>();

                foreach (Product prod in _salesTrackerContext.Products)
                {
                    ProductDTO productDTO = new ProductDTO();
                    productDTO.ProductId = prod.ProductId;
                    productDTO.Name = prod.Name;
                    productDTO.Manufacturer = prod.Manufacturer;
                    productDTO.Description = prod.Description;
                    productDTO.CommissionPercentage = prod.CommissionPercentage.ToString();
                    productDTO.SalePrice = prod.SalePrice.ToString();
                    productDTO.PurchasePrice = prod.PurchasePrice.ToString();
                    productDTO.QtyOnHand = prod.QtyOnHand.ToString();
                    productDTO.Style = prod.Style;
                    productDTOList.Add(productDTO);
                }
                getProductsResult.Products = productDTOList;
                getProductsResult.ResponseMessage = "Prodcutss retrieved successfully";
                getProductsResult.HasErrors = false;
            }             
            catch (Exception ex)
            {
                getProductsResult.ResponseMessage = ex.Message;
                getProductsResult.HasErrors =  true;
            }

            return getProductsResult;               
        }
        public UpdateProductResult UpdateProduct(ProductDTO productDTO)
        {
            UpdateProductResult updateProductResult = new UpdateProductResult();
 
            try
            {
                ProductDTO productDTOChanged = new ProductDTO();

                var productToChange = _salesTrackerContext.Products.Where(x => x.ProductId == productDTO.ProductId).FirstOrDefault();
                //productToChange.ProductId = productDTO.ProductId;
                productToChange.Name = productDTO.Name;
                productToChange.Manufacturer = productDTO.Manufacturer;
                productToChange.CommissionPercentage = Convert.ToDecimal(productDTO.CommissionPercentage);
                productToChange.SalePrice = Convert.ToDecimal(productDTO.SalePrice);
                productToChange.PurchasePrice = Convert.ToDecimal(productDTO.PurchasePrice);
                productToChange.QtyOnHand = Convert.ToInt32(productDTO.QtyOnHand);
                productToChange.Style = productDTO.Style;
                productToChange.Description = productDTO.Description;

                //productToChange = product;
                //_salesTrackerContext.ChangeTracker.AcceptAllChanges();
                _salesTrackerContext.Products.Update(productToChange);
                //_salesTrackerContext.Entry(productToChange).State = EntityState.Modified;
               
                _salesTrackerContext.SaveChanges();
                var productChanged = _salesTrackerContext.Products.Where(x => x.ProductId == productToChange.ProductId).FirstOrDefault();
                
                productDTOChanged.ProductId = productChanged.ProductId;
                productDTOChanged.Name = productChanged.Name;
                productDTOChanged.Manufacturer = productChanged.Manufacturer;
                productDTOChanged.CommissionPercentage = productChanged.CommissionPercentage.ToString();
                productDTOChanged.SalePrice = productChanged.SalePrice.ToString();
                productDTOChanged.PurchasePrice = productChanged.PurchasePrice.ToString();
                productDTOChanged.QtyOnHand = productChanged.QtyOnHand.ToString();
                productDTOChanged.Style = productChanged.Style;
                productDTOChanged.Description = productChanged.Description;

                updateProductResult.Product = productDTOChanged;
                updateProductResult.ResponseMessage = "Updated Prodcut successfully!";
                updateProductResult.HasErrors = false;
            }
            catch (Exception ex)
            {
                updateProductResult.HasErrors = true;
                updateProductResult.ResponseMessage = ex.Message;
                return updateProductResult;
            }

            return updateProductResult;
        }
    }
}
