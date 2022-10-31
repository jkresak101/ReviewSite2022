using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;

namespace ReviewSite.Data
{
    public class ReviewSiteContext : DbContext
    {
        public ReviewSiteContext (DbContextOptions<ReviewSiteContext> options)
            : base(options)
        {
        }

        public DbSet<ReviewSite.Models.Product> Product { get; set; } = default!;

        public DbSet<ReviewSite.Models.Review> Review { get; set; }
    }
}
