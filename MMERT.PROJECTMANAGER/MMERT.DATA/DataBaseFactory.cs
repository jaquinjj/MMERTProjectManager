using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMERT.DATA.Interfaces;


namespace MMERT.DATA
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Context _dataContext;

        public Context Get()
        {
            return _dataContext ?? (_dataContext = new Context());
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }
    }
}
