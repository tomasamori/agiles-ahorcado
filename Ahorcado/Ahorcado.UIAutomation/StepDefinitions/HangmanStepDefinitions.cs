using Ahorcado.Clase;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Policy;

namespace Ahorcado.UIAutomation.StepDefinitions
{
    [Binding]
    public sealed class HangmanStepDefinitions
    {
        IWebDriver? driver;
        String? baseURL;
        AhorcadoClase? Partida;

        [BeforeScenario]
        public void TestInitialize()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"\Drivers";
            driver = new ChromeDriver(path);
            baseURL = "https://localhost:44306/";
        }

        [Given(@"The word to guess '(.*)'")]
        public void GivenTheWordToGuess(string p0)
        {
            Partida = new AhorcadoClase("AGILES", 7);
            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(1000);
        }

        [When(@"I enter X as the LetraIngresada seven times")]
        public void WhenIEnterXAsTheTypedLetterSevenTimes()
        {
            for (int i = 0; i < 7; i++)
            {
                var letterTyped = driver.FindElement(By.Id("inputletter"));
                var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
                letterTyped.SendKeys("X");
                Thread.Sleep(1000);
                btnInsertLetter.Click();
            }
        }

        [Then(@"I should be told that I lost")]
        public void ThenIShouldBeToldThatILost()
        {

            var LabelGanar = driver.FindElement(By.Id("lost"));
            Assert.AreEqual(LabelGanar.Text, "¡Perdiste!");
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}