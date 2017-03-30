using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Library.Framework
{
    public interface IDatabaseInst
    {
        DatabaseType Type { get; }
        System.Data.IDbConnection Instance { get; }

        void Release();
    }
}
