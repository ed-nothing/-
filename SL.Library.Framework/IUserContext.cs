using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Library.Framework
{
    public interface IUserContext
    {
        bool IsLocal { get; }
        string RemoteAddr { get; }
    }
}
