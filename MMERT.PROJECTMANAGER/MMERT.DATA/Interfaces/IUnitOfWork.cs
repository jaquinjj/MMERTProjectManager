using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.DATA
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
