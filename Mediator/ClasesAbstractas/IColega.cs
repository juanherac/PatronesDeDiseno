using System;
using PatronesDeDiseno.Mediator.Interfaces;

namespace PatronesDeDiseno.Mediator.ClasesAbstractas
{
    public abstract class IColega
    {
        private IMediador mediador;
        public IMediador Mediador { get; }

        public IColega(IMediador aMediador)
        {
            this.mediador = aMediador;
        }

        public void Comunicar(string aMensaje)
        {
            this.mediador.EnviarMensaje(this, aMensaje);
        }

        public abstract void Recibir(string aMensaje);
    }
}
