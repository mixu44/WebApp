using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WebApp.Models
{
    public class SeedCars
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<WebAppContext>>()))
            {

                if (context.Car.Any())
                {
                    return;   // Cars has been seeded
                }

                context.Car.AddRange(
                     new Car
                     {
                         Brand = "VW",
                         Model = "Golf V",
                         Year = 2007,
                         Hk = 120,
                         Price = 270000


                     },
                     new Car
                     {
                         Brand = "Audi",
                         Model = "A6",
                         Year = 2013,
                         Hk = 220,
                         Price = 360000
                     },
                     new Car
                     {
                         Brand = "Ford",
                         Model = "Focus",
                         Year = 2016,
                         Hk = 170,
                         Price = 170000
                     },
                     new Car
                     {
                         Brand = "Jaguar",
                         Model = "XE",
                         Year = 2017,
                         Hk = 360,
                         Price = 400000
                     },
                     new Car
                     {
                         Brand = "Toyota",
                         Model = "Prius",
                         Year = 2015,
                         Hk = 90,
                         Price = 105000
                     }


                );
                context.SaveChanges();
            }
        }

    }
}
