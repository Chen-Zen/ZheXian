using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ZheXian.EntityFramework;

namespace ZheXian.Migrator
{
    [DependsOn(typeof(ZheXianDataModule))]
    public class ZheXianMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ZheXianDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}