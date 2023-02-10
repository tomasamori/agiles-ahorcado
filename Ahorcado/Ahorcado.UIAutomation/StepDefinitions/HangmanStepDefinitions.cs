using Ahorcado.Clase;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ahorcado.UIAutomation.StepDefinitions
{
    [Binding]
    public sealed class HangmanStepDefinitions
    {
        IWebDriver driver;
        String baseURL;
        AhorcadoClase partida = AhorcadoJuego.GetPartidaActual;

        [BeforeScenario]
        public void TestInitialize()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"\Drivers";
            driver = new ChromeDriver(path);
            baseURL = "https://localhost:44306/";
        }

        [When(@"I enter X as the typedLetter seven times")]
        public void WhenIEnterXAsTheTypedLetterSevenTimes()
        {
            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(5000);
            for (int i = 0; i < 7; i++)
            {
                var letterTyped = driver.FindElement(By.Id("inputletter"));
                var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
                letterTyped.SendKeys("X");
                Thread.Sleep(1000);
                btnInsertLetter.SendKeys(Keys.Enter);
            }
        }

        [Then(@"I should be told that I lost")]
        public void ThenIShouldBeToldThatILost()
        {
            
            var loss = partida.getVida() == 0;
            Thread.Sleep(1000);
            Assert.IsTrue(loss);
            Thread.Sleep(1000);
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}