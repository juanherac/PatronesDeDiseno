using System;
using PatronesDeDiseno.Decorator.Clases;
using PatronesDeDiseno.Decorator.Interfaces;

namespace PatronesDeDiseno.Decorator.ClasesAbstractas
{
    public abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria _cuenta;

        public CuentaDecorador(ICuentaBancaria aCuenta)
        {
            this._cuenta = aCuenta;
        }

        public virtual void AbrirCuenta(Cuenta aCuenta)
        {
            this._cuenta.AbrirCuenta(aCuenta);
        }
    }
}
