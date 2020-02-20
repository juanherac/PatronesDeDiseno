using System;
using PatronesDeDiseno.Factory.Interfaces;

namespace PatronesDeDiseno.Factory.Clases
{
    public class Cotizar
    {
        public string Cotiza(ICotizar aCotizacion)
        {
            if (aCotizacion is CotizarGNP)
                return aCotizacion.Cotizar();
            else
                return aCotizacion.Cotizar();
        }
    }
}
