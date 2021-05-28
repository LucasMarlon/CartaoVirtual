using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CartaoVirtual.Models
{
    public class CartaoContext : DbContext
    {
        public CartaoContext(DbContextOptions<CartaoContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cartao> Cartoes { get; set; }
    }
}
