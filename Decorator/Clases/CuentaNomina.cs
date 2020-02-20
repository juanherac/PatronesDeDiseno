using System;
using PatronesDeDiseno.Decorator.Interfaces;

namespace PatronesDeDiseno.Decorator.Clases
{
    public class CuentaNomina : ICuentaBancaria
    {
        public void AbrirCuenta(Cuenta aCuenta)
        {
            Console.WriteLine(string.Format("La cuenta de NOMINA {0} para el usuario {1} se ha abierto correctamente.", aCuenta.Id, aCuenta.Nombre));
        }
    }
}
