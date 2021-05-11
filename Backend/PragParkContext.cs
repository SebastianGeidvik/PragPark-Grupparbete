using Microsoft.EntityFrameworkCore;
using System;

namespace Backend
{
    public class PragParkContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Lars
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-KQBHCD4\SQLEXPRESS;Database=PragParkWinform;Trusted_Connection=True;MultipleActiveResultSets=true");
                //optionsBuilder.UseLazyLoadingProxies();

                //Tintin
                //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FPE71HP\SQLEXPRESS;Database=PragParkWinform;Trusted_Connection=True;MultipleActiveResultSets=true");
                //optionsBuilder.UseLazyLoadingProxies();

                //Björn
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=PragParkWinform;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}