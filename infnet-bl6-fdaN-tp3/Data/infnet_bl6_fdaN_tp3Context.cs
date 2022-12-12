using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using infnet_bl6_fdaN_at.Models;

namespace infnet_bl6_fdaN_at.Data
{
    public class infnet_bl6_fdaN_atContext : DbContext
    {
        public infnet_bl6_fdaN_atContext (DbContextOptions<infnet_bl6_fdaN_atContext> options)
            : base(options)
        {
        }

        public DbSet<infnet_bl6_fdaN_at.Models.Pessoa> Pessoa { get; set; } = default!;
    }
}
