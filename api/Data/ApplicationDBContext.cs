using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions DbContextOptions) : base(dbContextOptions){

        }
        public DbSet<Stock> Stock{ get; set; }
        public DbSet<Comment> Comment{get; set;}
                
    }
}