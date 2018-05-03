using System.Data.Common;
using Abp.Zero.EntityFramework;
using ZheXian.Authorization.Roles;
using ZheXian.Authorization.Users;
using ZheXian.MultiTenancy;

namespace ZheXian.EntityFramework
{
    public class ZheXianDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ZheXianDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ZheXianDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ZheXianDbContext since ABP automatically handles it.
         */
        public ZheXianDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ZheXianDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ZheXianDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
