using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Entities;
using SQLitePCL;

namespace SalesTrackBusiness
{
    public class DiscountManagement : IDiscountManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public List<DiscountDTO> GetDiscounts()
        {
            List<DiscountDTO> discountDTOList = new List<DiscountDTO>();

            try
            {
                foreach (Discount discount in _salesTrackerContext.Discounts)
                {
                    DiscountDTO discountDTO = new DiscountDTO();
                    discountDTO.DiscountId = discount.DiscountId;
                    discountDTO.ProductId = discount.ProductId;
                    discountDTO.BeginDate = discount.BeginDate;
                    discountDTO.EndDate = discount.EndDate;
                    discountDTO.DiscountPercentage = discount.DiscountPercentage;
                    discountDTOList.Add(discountDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return discountDTOList;
        }
      
    }
}

