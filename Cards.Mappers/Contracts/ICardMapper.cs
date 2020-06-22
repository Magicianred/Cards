using Cards.Domain;
using Cards.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Mappers
{
    public interface ICardMapper
    {
      ProductToCardResponse MapCardToCardResponse(Card card);
    }
}
