using Cards.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Repository.Contracts
{
    public interface ICardRepository
    {
        Task<Card> AddProductToCardAsync(Guid customerID, Guid productID,  int quantity);

    }
}
