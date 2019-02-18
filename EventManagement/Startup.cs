using Microsoft.Owin;
using Owin;
using EventManagement.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

[assembly: OwinStartupAttribute(typeof(EventManagement.Startup))]
namespace EventManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            InitializeRoles();
        }

        private void InitializeRoles()
        {
            using (var context = new ApplicationDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!roleManager.RoleExists("Admin"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Admin"
                    };

                    roleManager.Create(role);
                }
            }
        }
    }
}
