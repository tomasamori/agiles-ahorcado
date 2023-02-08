using System.Text;

namespace Ahorcado.Clase
{
    public class AhorcadoClase
    {
        public string palabra;
        public int vida;
        public List<char> letrasCorrectas;
        public List<char> letrasIncorrectas;
        public string estadoPalabra;

        public AhorcadoClase(string palabra, int vida)
        {
            this.palabra = palabra.ToLower();
            this.vida = vida;
            this.estadoPalabra = "";
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
                }

                else return "La letra ya fue ingresada";

                if (cont == 0)
                {
                    this.vida = this.vida - 1;
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

        public bool ValidarPalabra()
        {
            foreach (var letra in this.palabra.ToCharArray())
            {
                if (!this.letrasCorrectas.Contains(Char.ToLower(letra)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}