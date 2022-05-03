using System;

namespace EjerciciosLSP.Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IColor_de_Fruta color_De_Fruta = new Naranja();
            Console.WriteLine(color_De_Fruta.ObtenerColor());
        }
    }
}