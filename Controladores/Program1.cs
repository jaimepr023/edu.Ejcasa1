using educasa1.Servicios;

namespace educasa1.Controladores
{/// <summary>
/// Clase principal de la aplicacion
/// 260923-jpr
/// </summary>

    class program
    {

        /// <summary>
        /// Metodo inicial de nuestra aplicacion
        /// 260923-jpr
        /// </summary>
        /// <param name="args"></param>
       static void Main(string[] args)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mensajeBienvenida();
        }



    }
}
