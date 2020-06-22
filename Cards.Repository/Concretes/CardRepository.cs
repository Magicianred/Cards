using Cards.Domain;
using Cards.Repository.Contexts;
using Cards.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Repository.Concretes
{
    public class CardRepository : ICardRepository
    {
       
        public async Task<Card> AddProductToCardAsync(Guid customerID, Guid productID, int quantity)
        {
            using (var db = new CardContext())
            {

                var card = db.Cards
                    .Where(c => c.IsActive == true && c.CustomerID == customerID)
                    .Include(m => m.CardItems)
                    .Include(m => m.CardItems)
                    .FirstOrDefault();

                if (card != null)
                {
                    if (card.CardItems.Any(ci => ci.ProductID != productID))
                        card.CardItems.Add(new CardItem(customerID, productID, quantity));
                    else
                        card.CardItems.Where(ci => ci.ProductID == productID).FirstOrDefault().Quantity += quantity;
                }
                else
                {
                    db.Add(new Card(customerID, new List<CardItem>() { new CardItem(customerID, productID, quantity) }, true));
                }

                db.SaveChanges();

                return db.Cards.Where(c=>c.CustomerID == customerID && c.IsActive).FirstOrDefault();
            }


        }
    }
}

