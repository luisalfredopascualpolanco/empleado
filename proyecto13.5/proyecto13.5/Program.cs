using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13._5
{
    class Program
    {
        public class Empleados
        {
            private string nombre;
            private float sueldo;

            public void Cargar()
            {
                Console.Write("Nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Sueldo del empleado: ");
                sueldo = float.Parse(Console.ReadLine());
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre: "+nombre);
                Console.WriteLine("Sueldo: "+sueldo);
            }

            public void Impuesto() 
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine("Usted tiene que pagar impuestos");
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Empleados empleado = new Empleados();
                empleado.Cargar();
                empleado.Imprimir();
                empleado.Impuesto();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");
            }
            Console.ReadKey();
        }
    }
}
