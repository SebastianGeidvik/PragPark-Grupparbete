using Microsoft.EntityFrameworkCore;
using System;

namespace Backend
{
    public class DbContextPragPark : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-M2HEUQ01\SQLEXPRESS;Database=PragParkWinform;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}