using System;
using PatronesDeDiseno.Mediator.ClasesAbstractas;

namespace PatronesDeDiseno.Mediator.Interfaces
{
    public interface IMediador
    {
        public void EnviarMensaje(IColega aColega, string aMensaje);
    }
}
