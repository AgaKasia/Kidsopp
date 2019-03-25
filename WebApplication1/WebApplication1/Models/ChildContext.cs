using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ChildContext : DbContext
    {
        protected ChildContext(DbContextOptions<ChildContext>options):base(options)
        {
        }
        public DbSet<Child> Children { get; set; }
    }
}
