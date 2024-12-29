using SalesTrackCommon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackBusiness.Entities;

namespace SalesTrackBusiness.Interfaces
{
    public interface IProductsManagement
    {  
        List<ProductDTO> GetProducts();
        ProductDTO UpdateProduct(ProductDTO product);
    }
}
