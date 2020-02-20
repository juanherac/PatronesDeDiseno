using System;
using PatronesDeDiseno.Observer.ClasesAbstractas;

namespace PatronesDeDiseno.Observer.Clases
{
    public class Sol : AObservador
    {
        private double _tipoCambio = 5.00;
        public Sol(Sujeto aSujeto)
        {
            _sujeto = aSujeto;
            _sujeto.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine(string.Format("El costo por {0} Soles es de {1} pesos", _sujeto.Estado, (_sujeto.Estado * _tipoCambio).ToString("c")));
        }
    }
}
