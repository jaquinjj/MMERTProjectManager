using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
using System.Data.SqlClient;
using MMERT.DATA.Interfaces;

namespace MMERT.DATA
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private Context _dataContext;
        private readonly IDbSet<TEntity> _dbset;
        private string[] _paths;

    
        private readonly DbSet<TEntity> _dbSet;
 
        public Repository(Context context)
        {
            _dataContext = context;
            _dbSet = context.Set<TEntity>();
        }
 
        /// <summary>
        /// Tüm kayıtlar.
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }
 
        /// <summary>
        /// Kayıt bul.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity Find(int id)
        {
            return _dbSet.Find(id);
        }
 
        /// <summary>
        /// Kayıt ekle.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
 
        /// <summary>
        /// Kayıt güncelle.
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _dataContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
 
        /// <summary>
        /// Kayıt sil.
        /// </summary>
        /// <param name="id">Kayıt id</param>
        public virtual void Delete(int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }
 
        /// <summary>
        /// Kayıt sil.
        /// </summary>
        /// <param name="entityToDelete">Kayıt</param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (_dataContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }
    }
}
