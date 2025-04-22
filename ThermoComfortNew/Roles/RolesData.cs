using Microsoft.AspNetCore.Identity;
using ThermoComfortNew.Domain;

namespace ThermoComfortNew.Roles
{
    public class RolesData
    {
        public static void SeedRoles(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            ApplicationUserRoles(roleManager);
            RoleUsers(userManager);

        }

        private static void ApplicationUserRoles(RoleManager<IdentityRole> roleManager)
        {
            //ако ролята не съществува се създава
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };

                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("ApplicationUser").Result)
            {
                var role = new IdentityRole
                {
                    Name = "ApplicationUser"
                };

                var result = roleManager.CreateAsync(role).Result;
            }

        }

        private static void RoleUsers(UserManager<ApplicationUser> userManager)
        {

            //проверява дали има потребител или не
            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Admin",
                    FirstName = "Admin",
                    LastName = "administrator",
                    Email = "admin@gmail.com",
                    PhoneNumber = "0886688228"
                };

                //потребител с парола "tc4321"
                var result = userManager.CreateAsync(user, "tc4321").Result;

                if (result.Succeeded)
                {
                    //Wait - ни гарантира, че админът ще е създаден преди обикновения потребител т.е. първият създаден е админ
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }

            }
            if (userManager.FindByNameAsync("Tester").Result==null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Tester",
                    FirstName = "Tester",
                    LastName = "Testing",
                    Email = "test@gmail.com",
                    PhoneNumber = "0887872121"
                };
                var result = userManager.CreateAsync(user, "654321").Result;

            }

        }
    }
}
