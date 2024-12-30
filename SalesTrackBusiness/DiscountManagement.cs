using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTrackBusiness.Entities;
using SalesTrackBusiness.Interfaces;
using SalesTrackCommon.Entities;
using SalesTrackCommon.Models;
using SalesTrackCommon.Models.Results;
using SQLitePCL;

namespace SalesTrackBusiness
{
    public class DiscountManagement : IDiscountManagement
    {
        private SalesTrackerContext _salesTrackerContext = new SalesTrackerContext();
        public GetDiscountsResult GetDiscounts()
        {
            GetDiscountsResult discountResult = new GetDiscountsResult();
          
            try
            {
                List<DiscountDTO> discountDTOList = new List<DiscountDTO>();

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
                discountResult.Discounts = discountDTOList;
                discountResult.ResponseMessage = "Discounts retrieved successfully";
                discountResult.HasErrors = false;
            }
            catch (Exception ex)
            {
                discountResult.ResponseMessage = ex.Message;
                discountResult.HasErrors = true;
                return discountResult;
            }
            return discountResult;
        }        
    }
}

