using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.Clase
{
    public static class AhorcadoAuxiliares
    {
        private static readonly string[] palabras =
        {
            "AGILES",
            "AHORCADO",
            "MESA",
            "CASA"
        };

        public static string PalabraAleatoria()
        {
            return palabras[RandomNumberGenerator.GetInt32(palabras.Length)];
        }
    }
}
