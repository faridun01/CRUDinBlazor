using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDinBlazor.Data
{
    public class CRUDinBlazorContext : DbContext
    {
        public CRUDinBlazorContext (DbContextOptions<CRUDinBlazorContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
    }
}
