using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace MMERT.DATA
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Tüm kayıtlar.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Kayıt bul.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Find(int id);

        /// <summary>
        /// Kayıt ekle.
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Kayıt güncelle.
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(TEntity entityToUpdate);

        /// <summary>
        /// Kayıt sil.
        /// </summary>
        /// <param name="id">Kayıt id</param>
        void Delete(int id);

        /// <summary>
        /// Kayıt sil.
        /// </summary>
        /// <param name="entityToDelete">Kayıt</param>
        void Delete(TEntity entityToDelete);
    }
}
