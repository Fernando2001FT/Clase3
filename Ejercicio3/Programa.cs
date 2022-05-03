using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLSP.Ejercicio3
{
   public class Programa
    {
        public static void Main(string[] args)
        {
            ServicioDomicilio domicilio = new CafeteriaValles();
            Console.WriteLine(domicilio.ServicioDomicilio());
        }
    }
}
