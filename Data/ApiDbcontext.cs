using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Model;

namespace WebApi.Data
{
    public class ApiDbcontext : DbContext
    {
        public ApiDbcontext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Walks> walks { get;set;}

        public DbSet<Difficulty> difficulties{ get;set;}

        public DbSet<Region> regions{ get;set;}
   
    }
}