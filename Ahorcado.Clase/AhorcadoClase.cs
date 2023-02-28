using System.Text;
using static Ahorcado.Clase.AhorcadoClase;

namespace Ahorcado.Clase
{
    public class AhorcadoClase
    {
        private const int VIDAS = 7;
        public string palabra;
        public int vida;
        public List<char> letrasCorrectas;
        public List<char> letrasIncorrectas;
        public string estadoPalabra;
        public enum Estados { Jugando, Ganada, Perdida }
        public Estados estado { get; set; }

        public AhorcadoClase(string palabra)
        {
            this.palabra = palabra.ToLower();
            this.vida = VIDAS;
            this.estadoPalabra = "";
            this.estado = Estados.Jugando;
            for (int i = 0; i < this.palabra.Length; i++)
            {
                this.estadoPalabra += "_";
            }
            this.letrasCorrectas = new List<char>();
            this.letrasIncorrectas = new List<char>();
        }

        public string getPalabra()
        {
            return this.palabra;
        }

        public string adivinarLetra(char letra)
        {
            char letraLower = char.ToLower(letra);
            int cont = 0;

            if (validarLetra(letra))
            {
                if (!this.letrasCorrectas.Contains(letraLower))
                {
                    for (int i = 0; i < this.palabra.Length; i++)
                    {
                        if (this.palabra[i] == letraLower)
                        {
                            this.letrasCorrectas.Add(letraLower);
                            StringBuilder sb = new StringBuilder(this.estadoPalabra);
                            sb[i] = letraLower;
                            this.estadoPalabra = sb.ToString();
                            cont++;
                        }

                    }
                    if (String.Equals(this.palabra, this.estadoPalabra.ToLower()))
                    {
                        this.estado = Estados.Ganada;
                        return "Ganada";
                    }
                }

                else return "La letra ya fue ingresada";

                if (cont == 0)
                {
                    this.vida--;
                    this.letrasIncorrectas.Add(letra);
                    return "Letra incorrecta";
                }

                return "Acierto";
            }

            return "Debe ingresar una letra valida";
        }

        public bool validarLetra(char letra)
        {
            if (char.IsLetter(letra)) return true;
            return false;
        }

        public int getVida()
        {
            return this.vida;
        }

        public bool ValidarPalabra(string palabra)
        {
            if (String.Equals(this.palabra, palabra.ToLower()))
            {
                this.estado = Estados.Ganada;
                return true;
            }
            else
            {
                this.estado = Estados.Perdida;
                this.vida = 0;
                return false;
            }
        }
    }
}