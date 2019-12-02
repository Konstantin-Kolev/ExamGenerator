using ExamGenerator.Common;
using ExamGenerator.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace ExamGenerator.Data.Seeding
{
    public class AdminSeeder : ISeeder
    {
        public const string AdminUsername = "admin";
        public const string AdminEmail = "admin@root.dev";
        public const string AdminPassword = "123456";

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            UserManager<ApplicationUser> userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            ApplicationUser userFromDb = await userManager.FindByNameAsync(AdminUsername);

            if (userFromDb != null)
            {
                return;
            }

            var user = new ApplicationUser
            {
                Email = AdminEmail,
                UserName = AdminUsername,
                EmailConfirmed = true
            };

            await userManager.CreateAsync(user, AdminPassword);
            await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
        }
    }
}
