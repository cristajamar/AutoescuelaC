using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoescuela
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new Alumno();

                /*Solicitud Nombre*/
                Console.WriteLine("Nombre: ");
                a.Nombre = Console.ReadLine();

                /*Solicitud Edad*/
                Console.WriteLine("Edad: ");
                a.Edad = Convert.ToInt32(Console.ReadLine());


                /*Solicitud Permiso Actual*/
                Console.WriteLine("Permiso Actual: ");
                var permA = Console.ReadLine();
                var permAN = 0;

                if (int.TryParse(permA, out permAN))
                {
                    if (Enum.IsDefined(typeof(Permiso), permAN))
                    {
                        a.PActual = (Permiso)permAN;
                    }
                }
                else
                {
                    Permiso permisoA;
                    Permiso.TryParse(permA, out permisoA);
                    a.PActual = permisoA;
                }

                /*Solicitud Permiso nuevo*/
                Console.WriteLine("Permiso Nuevo: ");
                a.Nombre = Console.ReadLine();
                var permN = Console.ReadLine();
                var permNN = 0;

                /*Comprobamos su se ha introduccido un numero o una opción del Enum*/
                if (int.TryParse(permN, out permNN))
                {
                    /*Si es un numero, comprobamos que ese numero este definido como Enumerado*/
                    if (Enum.IsDefined(typeof(Permiso), permNN))
                    {
                        a.PNuevo = (Permiso)permNN;
                    }
                }
                /*Si no es un numero y es una opción del enum*/
                else
                {
                    Permiso permisoN;
                    Permiso.TryParse(permN, out permisoN);
                    a.PActual = permisoN;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
