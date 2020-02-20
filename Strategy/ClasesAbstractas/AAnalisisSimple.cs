using System;
using PatronesDeDiseno.Strategy.Interfaces;

namespace PatronesDeDiseno.Strategy.ClasesAbstractas
{
    public abstract class AAnalisisSimple : IEstrategia
    {
        public void Analizar()
        {
            IniciaAnalisis();
            EscaneoAnalisis();
            FinAnalisis();
        }

        public abstract void IniciaAnalisis();
        public abstract void EscaneoAnalisis();
        public abstract void FinAnalisis();
    }
}
