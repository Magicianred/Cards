using Cards.Domain;
using System;
using System.Collections.Generic;

namespace Cards.Responses
{
    public class ProductToCardResponse
    {
        public Guid CustomerID { get; set; }
        public List<CardItemResponse> CardItems { get; set; }
        public bool IsActive { get; set; }
        public ProductToCardResponse(Guid CustomerID, List<CardItemResponse> CardItems, bool IsActive)
        {
            this.CustomerID = CustomerID;
            this.CardItems = CardItems;
            this.IsActive = IsActive;
        }
    }
}
