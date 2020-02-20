using System;
using PatronesDeDiseno.Mediator.ClasesAbstractas;
using PatronesDeDiseno.Mediator.Interfaces;

namespace PatronesDeDiseno.Mediator.Clases
{
    public class UsuarioAdministrador : IColega
    {
        public UsuarioAdministrador(IMediador aMediador) : base(aMediador)
        {

        }

        public override void Recibir(string aMensaje)
        {
            Console.WriteLine(string.Format("El administrador recibe el mensaje: {0}", aMensaje));
        }
    }
}
