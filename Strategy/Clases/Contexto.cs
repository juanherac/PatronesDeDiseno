using System;
using PatronesDeDiseno.Strategy.Interfaces;

namespace PatronesDeDiseno.Strategy.Clases
{
    public class Contexto
    {
        IEstrategia _estrategia;

        public Contexto(IEstrategia aEstrategia)
        {
            this._estrategia = aEstrategia;
        }

        public void Ejecutar()
        {
            this._estrategia.Analizar();
        }
    }
}
