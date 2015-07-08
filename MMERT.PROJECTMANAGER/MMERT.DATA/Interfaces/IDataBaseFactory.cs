using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMERT.DATA
{
    public interface IDatabaseFactory : IDisposable
    {
        Context Get();
    }
}
