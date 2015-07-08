using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMERT.DATA.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Validation;


namespace MMERT.DATA
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;

        private Context _dataContext;

        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            Database.SetInitializer<Context>(null);

            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }

        public int SaveChanges()
        {
            try
            {
                if (_context == null)
                    throw new ArgumentNullException("_context");

                return _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var msg = string.Empty;

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                        msg += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;

                var fail = new Exception(msg, dbEx);

                throw fail;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
