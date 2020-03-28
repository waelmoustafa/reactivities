﻿using System;
using Microsoft.EntityFrameworkCore;
using Domain;
namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options ) :base(options){}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected  override void OnModelCreating( ModelBuilder builder)
        {
            builder.Seed();
        }
    }
}
