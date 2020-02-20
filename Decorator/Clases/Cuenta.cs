using System;
namespace PatronesDeDiseno.Decorator.Clases
{
    public class Cuenta
    {
        private int _id { get; set; }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _nombre { get; set; }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public Cuenta(int aId, string aNombre)
        {
            this._id = aId;
            this._nombre = aNombre;
        }
    }
}
