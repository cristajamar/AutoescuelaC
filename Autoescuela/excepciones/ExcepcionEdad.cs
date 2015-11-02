using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoescuela
{
    public class ExcepcionEdad : Exception
    {
        public ExcepcionEdad(int edad) : base("Edad Incorrecta " + edad) { }
    }
}
