//Added Data/Populated Data to be seed
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcSpoon.Data;
using System;
using System.Linq;

namespace MvcSpoon.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSpoonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcSpoonContext>>()))
            {
                // Look for any movies.
                if (context.Spoon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Spoon.AddRange(

                    new Spoon
                    {
                        TypeOfSpoon = "Tea",
                        Material = "Stainless Steel",
                        Measurement = 0.25M,
                        Color = "Silver",
                        Weight = 0.01M,
                        Price = 1.49M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Dinner",
                        Material = "Porcelain",
                        Measurement = 1 ,
                        Color = "White-Golden",
                        Weight = 0.05M,
                        Price = 11.99M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Coffee",
                        Material = "Wood",
                        Measurement = 0.50M,
                        Color = "Brown",
                        Weight = 0.01M,
                        Price = 2.99M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Soup",
                        Material = "Porcelain",
                        Measurement = 1.50M,
                        Color = "White",
                        Weight = 0.06M,
                        Price = 10.49M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Table",
                        Material = "Stainless Steel",
                        Measurement = 1,
                        Color = "Silver",
                        Weight = 0.02M,
                        Price = 2.49M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Korean",
                        Material = "Bamboo",
                        Measurement = 0.50M,
                        Color = "Brown",
                        Weight = 0.01M,
                        Price = 2.99M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Spork",
                        Material = "Silicon",
                        Measurement = 0.50M,
                        Color = "White",
                        Weight = 0.01M,
                        Price = 3.99M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Sauce",
                        Material = "Copper",
                        Measurement = 0.25M,
                        Color = "Golden",
                        Weight = 0.03M,
                        Price = 10.49M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Dessert",
                        Material = "Copper",
                        Measurement = 0.50M,
                        Color = "Rose Gold",
                        Weight = 0.06M,
                        Price = 19.99M
                    },

                    new Spoon
                    {
                        TypeOfSpoon = "Serving",
                        Material = "Stainless Steel",
                        Measurement = 1.50M,
                        Color = "Silver",
                        Weight = 0.03M,
                        Price = 5.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}