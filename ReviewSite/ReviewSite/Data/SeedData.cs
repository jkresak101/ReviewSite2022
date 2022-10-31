using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReviewSite.Data;
using System;
using System.Linq;


namespace ReviewSite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ReviewSiteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ReviewSiteContext>>()))
            {
                // Look for any Products
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Rubber Duck",
                        Image = "RubberDucky.png",
                        Description = "A cool companion",

                    },

                    new Product
                    {
                        Name = "Anvil ",
                        Image = "Anvil.png",
                        Description = "Heavy as the weight on your shoulders",

                    },

                    new Product
                    {
                        Name = "Neon Light",
                        Image = "NeonLight.png",
                        Description = "Light of Love in bright Neon",

                    });

                // Look for any Reviews
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Review.AddRange(
                    new Review
                    {
                        ProductId = 1,
                        Reviewer_Name = "The Real Rubber Ducky",
                        Product_Review = "Stolen valor!",

                    },

                    new Review
                    {
                        ProductId = 2,
                        Reviewer_Name = "Vulcan",
                        Product_Review = "Looks great! Will be perfect for Thor's next hammer.",

                    }) ;

                context.SaveChanges();
            }
        }
    }
}
