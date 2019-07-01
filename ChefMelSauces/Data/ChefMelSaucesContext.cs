using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChefMelSauces.Models
{
    public class ChefMelSaucesContext : DbContext
    {
        public ChefMelSaucesContext (DbContextOptions<ChefMelSaucesContext> options)
            : base(options)
        {
        }

        public DbSet<ChefMelSauces.Models.ECommerce> ECommerce { get; set; }
    }
}
