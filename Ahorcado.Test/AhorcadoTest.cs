using Ahorcado.Clase;

namespace Ahorcado.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarLetraCorrecta()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.That(ahorcado.adivinarLetra('a'), Is.EqualTo("Acierto"));
        }

        [Test]
        public void ValidarLetraMayusculaCorrecta()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.That(ahorcado.adivinarLetra('A'), Is.EqualTo("Acierto"));
        }

        [Test]
        public void ValidarLetraIncorrecta()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.That(ahorcado.adivinarLetra('k'), Is.EqualTo("Letra incorrecta"));
        }

        [Test]
        public void ValidarLetraIncorrectaMayuscula()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.That(ahorcado.adivinarLetra('K'), Is.EqualTo("Letra incorrecta"));
        }

        [Test]
        public void ValidarEspacioBlanco()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.That(ahorcado.adivinarLetra(' '), Is.EqualTo("Debe ingresar una letra valida"));
        }

        [Test]
        public void ValidarComa()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.That(ahorcado.adivinarLetra(','), Is.EqualTo("Debe ingresar una letra valida"));
        }

        [Test]
        public void ValidarEstadoPalabra()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            ahorcado.adivinarLetra('a');

            Assert.That(ahorcado.estadoPalabra, Is.EqualTo("_a_a__a"));
        }

        [Test]
        public void ValidarQuitarVida()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);
            
            ahorcado.adivinarLetra('e');

            Assert.That(ahorcado.getVida(), Is.EqualTo(6));
        }
    }
}