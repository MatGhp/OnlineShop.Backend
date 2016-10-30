namespace WebShopAPIs.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebShopAPIs.Models.DB;
    using WebShopAPIs.Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<WebShopAPIs.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebShopAPIs.Infrastructure.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            


            

            var superAdmin = new User
            {
                UserName = "SuperAdmin",
                Email = "superadmin@gmail.com",
                EmailConfirmed = true,
                FirstName = "Mojtaba",
                LastName = "Ghanaat Pisheh",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3),
                IsActive = true
            };

            

            var admin = new User
            {
                UserName = "Admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Doe",
                Level = 2,
                JoinDate = DateTime.Now.AddYears(2),
                IsActive = true
            };

           

            var manager = new UserManager<User>(new UserStore<User>(new ApplicationDbContext()));
            var categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Damen",
                    Products = new List<Product> {
                new Product
                {
                    Id=1,
                    CategoryId = 1,
                    Name="Melrose Jerseykleid mit Zipper-Details",
                    Color ="black",
                    Description="Jerseykleid",
                    Details="Nothing",
                    ImageUrl="https://i.otto.de/i/otto/15947591?$responsive_product$",
                    IsActive=true,
                    Price=140,
                    Size=11
                },
                 new Product
                {
                    Id=2,
                    CategoryId = 1,
                    Name="BOYSEN'S Boysen's Jerseykleid in Wickeloptik",
                    Color ="Black",
                    Description="",
                    Details="",
                    ImageUrl="https://i.otto.de/i/otto/15947591?$responsive_product$",
                    IsActive=true,
                    Price=230,
                    Size=11
                },
                  new Product
                {
                    Id=3,
                    CategoryId = 1,
                    Name="Pepe Jeans Druckkleid »Andrea« mit Unterkleid",
                    Color ="blue",
                    Description="Druckkleid",
                    Details="",
                    ImageUrl="https://i.otto.de/i/otto/15947591?$responsive_product$",
                    IsActive=true,
                    Price=400,
                    Size=200
                  }
                    }
                },
                new Category
                {
                    Id=2,
                    Name="Herren",
                    Products = new List<Product>{
                          new Product{
                    Id=4,
                    CategoryId = 2,
                    Name="Bruno Banani Lederjacke",
                    Color ="green",
                    Description="Lederjacke",
                    Details="nothing",
                    ImageUrl="https://i.otto.de/i/otto/15947591?$responsive_product$",
                    IsActive=true,
                    Price=30,
                    Size=11},
                    new Product{
                    Id=5,
                    CategoryId = 2,
                    Name="Lederjacke mit schönen Absteppungen",
                    Color ="pink",
                    Description="Kinder unten 5 Jahr",
                    Details="",
                    ImageUrl="https://i.otto.de/i/otto/15947591?$responsive_product$",
                    IsActive=true,
                    Price=40,
                    Size=120}
                    }
                },
                new Category
                {
                    Id=3,
                    Name="Kinder",
                    Products = new List<Product>
                    {
                          new Product
                {
                    Id=6,
                    CategoryId = 3,
                    Name="Arizona Poncho mit coolem Karomuster",
                    Color ="red",
                    Description="coolem Karomuster",
                    Details="No Details",
                    ImageUrl="https://i.otto.de/i/otto/15947591?$responsive_product$",
                    IsActive=true,
                    Price=10,
                    Size=92
                }
                    }
                },
                new Category
                {
                    Id=4,
                    Name="Sport"
                },
                new Category
                {
                    Id=5,
                    Name="Schuhe"
                },
                new Category
                {
                    Id=6,
                    Name="Haushalt"
                }
            };
            foreach (var cat in categories)
            {
                context.Categories.Add(cat);
            }



            manager.Create(superAdmin, "asd");
            manager.Create(admin, "asd");




            base.Seed(context);

        }


    }
}
