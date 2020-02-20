using System;
namespace PatronesDeDiseno.Singleton
{
    public class Singleton
    {
        public string Mensaje = string.Empty;

        protected Singleton()
        {
            Mensaje = "De acuerdo!";
        }

        private static Singleton instancia = null;
        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Singleton();

                return instancia;
            }
        }
    }
}
