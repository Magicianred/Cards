using Cards.Commands.API.Commands;
using Cards.Mappers;
using Cards.Repository.Contracts;
using Cards.Responses;
using MediatR;
using Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cards.Commands.API.Handlers
{
    public class CreateProductToCardHandler : IRequestHandler<CreateProductToCardCommand, ProductToCardResponse>
    {
        private ICardRepository _cardRepository;
        private ICardMapper _cardMapper;
        public CreateProductToCardHandler(ICardRepository cardRepository, ICardMapper cardMapper)
        {
            _cardRepository = cardRepository;
            _cardMapper = cardMapper;
        }
        public async Task<ProductToCardResponse> Handle(CreateProductToCardCommand request, CancellationToken cancellationToken)
        {
            if (StockControl.HasProductStockEnough(request.ProductID, request.Quantity))
            {
                var card = await _cardRepository.AddProductToCardAsync(request.CustomerID, request.ProductID, request.Quantity);
                return _cardMapper.MapCardToCardResponse(card);
            }
            else
                throw new Exception("Ürün stokta bulunmuyor");  
        }
    }
}