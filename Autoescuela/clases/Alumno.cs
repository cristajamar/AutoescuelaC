using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoescuela
{
    public enum Permiso { A, B, C, D }
    public class Alumno
    {
        public String Nombre { get; set; }
        private Int32 _edad;
        public Int32 Edad
        {
            get { return _edad; }
            set
            {
                if (value < 18 || value > 65)
                {
                    throw new ExcepcionEdad(value);
                }

                _edad = value;
            }
        }
        public Permiso PActual { get; set; }
        private Permiso _pnuevo;
        public Permiso PNuevo
        {
            get{ return _pnuevo; }
            set
            {
                if ((int)value > (int)PActual + 1)
                {
                    throw new ExcepcionPermisos("Permiso incorrecto");
                }
                _pnuevo = value;
            }
        }
    }
}




