using Products.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cards.Domain
{
    public class Card
    {
        [Key]
        public long CardID { get; set; } 
        public Guid CustomerID { get; set; }
        public List<CardItem> CardItems { get; } = new List<CardItem>(); 
        public bool IsActive { get; set; }
        public Card(){ }
        public Card(Guid CustomerID, List<CardItem> CardItems, bool IsActive) 
        { 
            this.CustomerID = CustomerID;
            this.CardItems = CardItems;
            this.IsActive = IsActive;
        }
    }
    
}
