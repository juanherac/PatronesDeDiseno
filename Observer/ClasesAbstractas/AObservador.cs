using System;
using PatronesDeDiseno.Observer.Clases;

namespace PatronesDeDiseno.Observer.ClasesAbstractas
{
    public abstract class AObservador
    {
        protected Sujeto _sujeto;
        public abstract void Actualizar();
    }
}
