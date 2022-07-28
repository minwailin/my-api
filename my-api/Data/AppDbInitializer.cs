using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any())
                {
                    //AddRange use for to add more than one dummy data
                    context.Books.AddRange(new Book()
                    {
                        Title = "First Title",
                        Description = "First Desc",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverPhoto = "https ... ",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "Second Title",
                        Description = "Second Desc",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-8),
                        Rate = 3,
                        CoverPhoto = "https ... ",
                        DateAdded = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
