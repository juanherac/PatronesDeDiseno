using System;
using System.Collections.Generic;
using PatronesDeDiseno.Mediator.ClasesAbstractas;
using PatronesDeDiseno.Mediator.Interfaces;

namespace PatronesDeDiseno.Mediator.Clases
{
    public class Mediador : IMediador
    {
        private List<IColega> colegas;

        public Mediador()
        {
            colegas = new List<IColega>();
        }

        public void AgregarColega(IColega aColega)
        {
            this.colegas.Add(aColega);
        }

        public void EnviarMensaje(IColega aColega, string aMensaje)
        {
            foreach (var colega in this.colegas)
            {
                if (colega != aColega)
                {
                    colega.Recibir(aMensaje);
                }
            }
        }
    }
}
