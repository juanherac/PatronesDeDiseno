using System;
using PatronesDeDiseno.Factory.Interfaces;

namespace PatronesDeDiseno.Factory.Clases
{
    public class CotizarAXA : ICotizar
    {
        private string _marca { get; set; }
        private string _modelo { get; set; }
        private string _version { get; set; }
        private int _anio { get; set; }

        public CotizarAXA(string aMarca, string aModelo, string aVersion, int aAnio)
        {
            this._marca = aMarca;
            this._modelo = aModelo;
            this._version = aVersion;
            this._anio = aAnio;
        }

        public string Cotizar()
        {
            return string.Format("Cotizar con Axa el siguiente auto: Marca: {0}, Modelo: {1}, Versión: {2}, Año: {3}", _marca, _modelo, _version, _anio);
        }
    }
}
