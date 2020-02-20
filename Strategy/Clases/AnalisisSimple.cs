using System;
using PatronesDeDiseno.Strategy.ClasesAbstractas;

namespace PatronesDeDiseno.Strategy.Clases
{
    public class AnalisisSimple : AAnalisisSimple
    {
        public override void EscaneoAnalisis()
        {
            Console.WriteLine("Escanea el analisis simple");
        }

        public override void FinAnalisis()
        {
            Console.WriteLine("Finaliza el analisis simple");
        }

        public override void IniciaAnalisis()
        {
            Console.WriteLine("Inicia el analisis simple");
        }
    }
}
