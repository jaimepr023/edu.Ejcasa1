using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace educasa1.Servicios
{

    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Clase que implementa la interfaz del menu
        /// </summary>
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a la Grieta del Invocador.";
            Console.WriteLine(mensaje);
        }

    }
    
    
}
