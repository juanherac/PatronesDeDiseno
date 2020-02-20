using System;
using PatronesDeDiseno.Observer.ClasesAbstractas;

namespace PatronesDeDiseno.Observer.Clases
{
    public class Dolar : AObservador
    {
        private double _tipoCambio = 18.00;
        public Dolar(Sujeto aSujeto)
        {
            _sujeto = aSujeto;
            _sujeto.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine(string.Format("El costo de {0} Dolares es de {1} pesos", _sujeto.Estado, (_sujeto.Estado * _tipoCambio).ToString("c")));
        }
    }
}
