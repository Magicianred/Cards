using Cards.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Commands.API.Commands
{
    public class CreateProductToCardCommand : IRequest<ProductToCardResponse>
    {
        [Required]
        public Guid CustomerID { get; set; }
        [Required]
        public Guid ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        public CreateProductToCardCommand()
        {

        }
        public CreateProductToCardCommand(Guid CustomerID, Guid ProductID, int Quantity)
        {
            this.CustomerID = CustomerID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
        }
    }
} 
