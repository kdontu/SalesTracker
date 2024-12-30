using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;

namespace SalesTrackBusiness.Interfaces
{
    public interface IProductsManagement
    {  
        GetProductsResult GetProducts();
        UpdateProductResult UpdateProduct(ProductDTO product);
    }
}
