﻿using System;
using PatronesDeDiseno.Mediator.ClasesAbstractas;
using PatronesDeDiseno.Mediator.Interfaces;

namespace PatronesDeDiseno.Mediator.Clases
{
    public class Usuario : IColega
    {
        public Usuario(IMediador aMediador) : base(aMediador)
        {

        }

        public override void Recibir(string aMensaje)
        {
            Console.WriteLine(string.Format("El empleado recibe el mensaje: {0}", aMensaje));
        }
    }
}
