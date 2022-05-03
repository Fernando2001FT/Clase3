using System;

namespace EjerciciosLSP.Ejercicio3
{
    public class CafeteriaValles : ServicioDomicilio
    {
        public string ServicioDomicilio()
        {
            throw new Exception("No se realizan pedidos a domicilio");
        }
    }
}