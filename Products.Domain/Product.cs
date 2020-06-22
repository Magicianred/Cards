using System;

namespace Products.Domain
{
    public class Product : ProductBase
    {
        public Product(Guid ProductID, string Name, int Quantity, decimal Price) : base(ProductID, Name, Quantity, Price)
        { 
        }
    }
}
