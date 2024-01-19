
using Microsoft.AspNetCore.Identity;

namespace FarmaMundo.DAL
{
    public class LoadDatabase
    {
        public static async Task CargarData(DatabaseContext context,
         UserManager<ApplicationUser> userManager,
          RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole("ADMIN"));
            }

            if (!userManager.Users.Any())
            {
                var usuario = new ApplicationUser
                {
                    Name = "santiago",
                    Email = "scoronadovasc@gmail.com",
                    UserName = "scoronadovasco"

                };

                await userManager.CreateAsync(usuario, "ac6f1cf3");
                await userManager.AddToRoleAsync(usuario, "ADMIN");
            }
            if (!context.Categories!.Any())
            {
                context.Categories.AddRange(
                    new Category { Name = "Farmaceuticos" },
                    new Category { Name = "Esteticos" },
                    new Category { Name = "Saludables" },
                    new Category { Name = "Naturales" },
                    new Category { Name = "Vida Sexual" }
                );
            }

            if (!context.Products.Any())
            {
                context.Products!.AddRange(
                    new Product
                    {
                        Name = "Amosixilina",
                        CreateDate = DateTime.Now,
                        img = "amox.jpg",
                        Fabricante = "bayern"
                    }

                );
            }

            if (!context.ProductCategories!.Any())
            {
                context.ProductCategories!.AddRange(
                    new ProductCategory{CategoryId = 1,ProductId = 1},
                    new ProductCategory{ CategoryId = 2, ProductId = 2});
            }

            context.SaveChanges();
        }
        

        
    }
}