using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAndreVeiculosSummary.Data
{
    public class ProjAndreVeiculosSummaryContext : DbContext
    {
        public ProjAndreVeiculosSummaryContext (DbContextOptions<ProjAndreVeiculosSummaryContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Customer> Customer { get; set; } = default!;

        public DbSet<Models.Address>? Address { get; set; }
    }
}
