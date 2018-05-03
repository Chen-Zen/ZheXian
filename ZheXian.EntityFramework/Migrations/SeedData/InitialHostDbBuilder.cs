using ZheXian.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ZheXian.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ZheXianDbContext _context;

        public InitialHostDbBuilder(ZheXianDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
