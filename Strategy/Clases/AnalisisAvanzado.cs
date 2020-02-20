using System;
using PatronesDeDiseno.Strategy.ClasesAbstractas;

namespace PatronesDeDiseno.Strategy.Clases
{
    public class AnalisisAvanzado : AAnalisisAvanzado
    {
        public override void AbreAnalisis()
        {
            Console.WriteLine("Abre el analisis avanzado");
        }

        public override void FinAnalisis()
        {
            Console.WriteLine("Fin del analisis avanzado");
        }

        public override void IniciaAnalisis()
        {
            Console.WriteLine("Inicia el analisis avanzado");
        }

        public override void ProcesaAnalisis()
        {
            Console.WriteLine("Procesa el analisis avanzado");
        }

        public override void ReportaAnalisis()
        {
            Console.WriteLine("Reporta el analisis avanzado");
        }
    }
}
