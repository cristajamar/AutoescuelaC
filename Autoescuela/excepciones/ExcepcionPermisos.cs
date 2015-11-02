using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoescuela
{
    public class ExcepcionPermisos : Exception
    {
        public ExcepcionPermisos(String msg) : base(msg) { }
    }
}
