using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Data
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(ApplicationDbContext context, IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "User" };
            IdentityResult roleResult;
            foreach (var RoleName in roleNames)
            {
                var roleExists = await RoleManager.RoleExistsAsync(RoleName);
                if (!roleExists)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(RoleName));
                }
            }

            string Email = "admin@admin.com";
            string Password = "AdminPass12345";
            
            if (userManager.FindByEmailAsync(Email).Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = Email;
                user.Email = Email;

                IdentityResult result = userManager.CreateAsync(user, Password).Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }    
        }

        internal static object InitializeAsync(ApplicationDbContext context, IServiceProvider services, UserManager<ApplicationDbContext> userManager)
        {
            throw new NotImplementedException();
        }
    }
}
