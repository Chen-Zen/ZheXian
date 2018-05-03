using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ZheXian.EntityFramework.Repositories
{
    public abstract class ZheXianRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ZheXianDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ZheXianRepositoryBase(IDbContextProvider<ZheXianDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ZheXianRepositoryBase<TEntity> : ZheXianRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ZheXianRepositoryBase(IDbContextProvider<ZheXianDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
