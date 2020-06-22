using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Responses
{
    public class CardItemResponse
    {
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public CardItemResponse(Guid ProductID, int Quantity)
        {
            this.ProductID = ProductID;
            this.Quantity = Quantity;
        }
    }
}
