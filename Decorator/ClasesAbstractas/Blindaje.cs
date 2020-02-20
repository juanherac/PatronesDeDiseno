using System;
using PatronesDeDiseno.Decorator.Clases;
using PatronesDeDiseno.Decorator.Interfaces;

namespace PatronesDeDiseno.Decorator.ClasesAbstractas
{
    public class Blindaje : CuentaDecorador
    {
        public Blindaje(ICuentaBancaria aCuenta) : base(aCuenta)
        {

        }

        public override void AbrirCuenta(Cuenta aCuenta)
        {
            _cuenta.AbrirCuenta(aCuenta);
            Console.WriteLine(string.Format("Se blinja la cuenta {0} de la persona {1}", aCuenta.Id, aCuenta.Nombre));
        }
    }
}
