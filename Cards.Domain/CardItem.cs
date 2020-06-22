using Products.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cards.Domain
{
    public class CardItem
    {
        [Key] 
        [ForeignKey("Card")]
        public int CardItemID { get; set; }
        [ForeignKey("Card")]
        public long CardID { get; set; }

        public Guid CustomerID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }

        public CardItem() { }
        public CardItem(Guid CustomerID, Guid ProductID, int Quantity)
        {
            this.CustomerID = CustomerID; 
            this.ProductID = ProductID; 
            this.Quantity = Quantity; 
        }
    }
    
}
