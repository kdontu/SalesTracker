using SalesTrackCommon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackBusiness.Interfaces;
using SalesTrackBusiness.Entities;
using Microsoft.EntityFrameworkCore;


namespace SalesTrackBusiness
{
    public class ProductsManagement : IProductsManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public List<ProductDTO> GetProducts()
        {
            List<ProductDTO> productDTOList = new List<ProductDTO>();

            try
            {                     
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
            }             
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return productDTOList;
        }
        public ProductDTO UpdateProduct(ProductDTO productDTO)
        {
            ProductDTO productDTOChanged = new ProductDTO();
            try
            {
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return productDTOChanged;
        }
    }
}
