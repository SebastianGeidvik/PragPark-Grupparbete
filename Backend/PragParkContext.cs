﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Backend
{
    public class PragParkContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-KQBHCD4\SQLEXPRESS;Database=PragParkWinform;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}