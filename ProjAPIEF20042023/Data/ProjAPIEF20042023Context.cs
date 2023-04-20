using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIEF20042023.Models;

namespace ProjAPIEF20042023.Data
{
    public class ProjAPIEF20042023Context : DbContext
    {
        public ProjAPIEF20042023Context (DbContextOptions<ProjAPIEF20042023Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIEF20042023.Models.Animal> Animal { get; set; } = default!;

        public DbSet<ProjAPIEF20042023.Models.Client>? Client { get; set; }

        public DbSet<ProjAPIEF20042023.Models.Address> Address { get; set; }
    }
}
