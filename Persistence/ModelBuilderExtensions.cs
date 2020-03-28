using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedValuesData(modelBuilder);
            SeedActivitiesData(modelBuilder);
        }
        private static void SeedValuesData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>()
            .HasData(
                new Value {Id=1, Name="Value 101"},
                new Value {Id=2, Name="Value 102"},
                new Value {Id=3, Name= "Value 103"}
            );
        }
        private static void SeedActivitiesData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
            .HasData(
                new Activity 
                    {
                        Id = Guid.NewGuid(),
                        Title = "Past Activity 1",
                        Date = DateTime.Now.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                    }
            );
        }
    }
}