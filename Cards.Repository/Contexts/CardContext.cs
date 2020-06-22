using Cards.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.Repository.Contexts
{
    public class CardContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                  => options.UseSqlite("Data Source=ecommerce_cs.db");
        
        public DbSet<Card> Cards { get; set; }
    }
}
