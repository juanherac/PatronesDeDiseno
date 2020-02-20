using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PatronesDeDiseno.Decorator.Clases;
using PatronesDeDiseno.Decorator.ClasesAbstractas;
using PatronesDeDiseno.Decorator.Interfaces;
using PatronesDeDiseno.Factory.Clases;
using PatronesDeDiseno.Mediator.Clases;
using PatronesDeDiseno.Mediator.ClasesAbstractas;
using PatronesDeDiseno.Observer.Clases;
using PatronesDeDiseno.Strategy.Clases;

namespace PatronesDeDiseno.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            #region Singleton
            Console.WriteLine(Singleton.Singleton.Instancia.Mensaje);
            Singleton.Singleton.Instancia.Mensaje = "Patrón de diseño Singleton";
            Console.WriteLine(Singleton.Singleton.Instancia.Mensaje);
            #endregion Singleton

            #region Factory
            Cotizar oCotizar = new Cotizar();
            Console.WriteLine(oCotizar.Cotiza(new CotizarGNP("Mazda","3","HB", 2015)));
            Console.WriteLine(oCotizar.Cotiza(new CotizarAXA("Mazda", "3", "HB", 2015)));
            #endregion Factory

            #region Mediator
            Mediador oMediador = new Mediador();
            IColega oUsuario1 = new Usuario(oMediador);
            IColega oAdministrador1 = new UsuarioAdministrador(oMediador);
            oMediador.AgregarColega(oUsuario1);
            oMediador.AgregarColega(oAdministrador1);
            oUsuario1.Comunicar("Hola, tengo un problema.");
            oAdministrador1.Comunicar("Cual es tu problema?");
            oUsuario1.Comunicar("Necesito que me instales un programa.");
            oAdministrador1.Comunicar("Ok, voy en camino.");
            #endregion Mediator

            #region Decorator
            Cuenta oCuenta = new Cuenta(1, "Juan");

            ICuentaBancaria cuentaNomina = new CuentaNomina();
            ICuentaBancaria cuentaNominaBlindada = new Blindaje(cuentaNomina);
            cuentaNominaBlindada.AbrirCuenta(oCuenta);
            #endregion Decorador

            #region Observer
            int cantidad = 1;
            Sujeto oSujeto = new Sujeto();
            new Peso(oSujeto);
            new Sol(oSujeto);
            new Dolar(oSujeto);

            Console.WriteLine(string.Format("Se requieren {0} unidades.", cantidad));
            oSujeto.Estado = cantidad;

            cantidad = 10;
            Console.WriteLine(string.Format("Se requieren {0} unidades.", cantidad));
            oSujeto.Estado = cantidad;
            #endregion Observer

            #region Strategy
            Contexto oContexto = new Contexto(new AnalisisSimple());
            oContexto.Ejecutar();

            oContexto = new Contexto(new AnalisisAvanzado());
            oContexto.Ejecutar();

            #endregion
        }
    }
}
