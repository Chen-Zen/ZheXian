using System.Linq;
using ZheXian.EntityFramework;
using ZheXian.MultiTenancy;

namespace ZheXian.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ZheXianDbContext _context;

        public DefaultTenantCreator(ZheXianDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
