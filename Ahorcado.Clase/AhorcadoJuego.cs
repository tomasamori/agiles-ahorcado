using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.Clase
{
    public class AhorcadoJuego
    {
        static AhorcadoClase PartidaActual;

        public static AhorcadoClase GetPartidaActual
        {
            get
            {
                return PartidaActual;
            }
        }

        public static void Inicializar()
        {
            PartidaActual = new AhorcadoClase(AhorcadoAuxiliares.PalabraAleatoria());
        }

        public static void Inicializar(string palabra)
        {
            PartidaActual = new AhorcadoClase(palabra);
        }
    }
}
