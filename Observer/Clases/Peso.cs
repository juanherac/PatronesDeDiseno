using System;
using PatronesDeDiseno.Observer.ClasesAbstractas;

namespace PatronesDeDiseno.Observer.Clases
{
    public class Peso : AObservador
    {
        private double _tipoCambio = 1.00;
        public Peso(Sujeto aSujeto)
        {
            _sujeto = aSujeto;
            _sujeto.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine(string.Format("El costo por {0} pesos es de {1} pesos", _sujeto.Estado, (_sujeto.Estado * _tipoCambio).ToString("c")));
        }
    }
}
