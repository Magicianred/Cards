using System;

namespace Products.Domain
{
    public class ProductBase
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ProductBase(Guid ProductID, string Name, int Quantity, decimal Price)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
        }
    }
}