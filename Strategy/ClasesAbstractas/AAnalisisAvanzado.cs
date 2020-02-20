using System;
using PatronesDeDiseno.Strategy.Interfaces;

namespace PatronesDeDiseno.Strategy.ClasesAbstractas
{
    public abstract class AAnalisisAvanzado : IEstrategia
    {
        public void Analizar()
        {
            IniciaAnalisis();
            AbreAnalisis();
            ProcesaAnalisis();
            ReportaAnalisis();
            FinAnalisis();
        }

        public abstract void IniciaAnalisis();
        public abstract void AbreAnalisis();
        public abstract void ProcesaAnalisis();
        public abstract void ReportaAnalisis();
        public abstract void FinAnalisis();
    }
}
