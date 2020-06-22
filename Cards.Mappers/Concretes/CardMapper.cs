using Cards.Domain;
using Cards.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Mappers.Concretes
{
    public class CardMapper : ICardMapper
    {
        public ProductToCardResponse MapCardToCardResponse(Card card)
        {
            List<CardItemResponse> cardItemResponses = new List<CardItemResponse>();

            foreach (var cardItem in card.CardItems) 
                cardItemResponses.Add(new CardItemResponse(cardItem.ProductID, cardItem.Quantity)); 
             
            return new ProductToCardResponse(card.CustomerID, cardItemResponses, card.IsActive);

        }
    }
}
