#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mayrazorpages.Pages.hobbies;

namespace mayrazorpages.Data
{
    public class mayrazorpagesContext : DbContext
    {
        public mayrazorpagesContext (DbContextOptions<mayrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<mayrazorpages.Pages.hobbies.Class> Class { get; set; }
    }
}
