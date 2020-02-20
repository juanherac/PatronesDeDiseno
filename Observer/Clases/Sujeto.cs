using System;
using System.Collections.Generic;
using PatronesDeDiseno.Observer.ClasesAbstractas;

namespace PatronesDeDiseno.Observer.Clases
{
    public class Sujeto
    {
        private int _estado;
        public int Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
                NotificarObservadores();
            }
        }

        private List<AObservador> _observadores = new List<AObservador>();

        public void AgregarObservador(AObservador aObservador)
        {
            this._observadores.Add(aObservador);
        }

        public void NotificarObservadores()
        {
            this._observadores.ForEach(o => o.Actualizar());
        }
    }
}
