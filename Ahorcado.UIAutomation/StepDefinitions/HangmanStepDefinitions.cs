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
        IWebDriver driver = new ChromeDriver();
        String baseURL = "https://agilesahorcado.azurewebsites.net/";

        [BeforeScenario]
        public void TestInitialize()
        {
            
        }

        [Given(@"The word to guess '(.*)'")]
        public void GivenTheWordToGuess(string p0)
        {
            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(1000);
        }

        [When(@"I enter X as the LetraIngresada seven times")]
        public void WhenIEnterXAsTheLetraIngresadaSevenTimes()
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

        [Then(@"I should be told that I lost the game")]
        public void ThenIShouldBeToldThatILost()
        {
            var LabelGanar = driver.FindElement(By.Id("lost"));
            Assert.AreEqual(LabelGanar.Text, "¡Perdiste!");
        }

        [When(@"I entered A as the LetraIngresada")]
        public void WhenIEnteredAAsTheLetraIngresada()
        {
            var letterTyped = driver.FindElement(By.Id("inputletter"));
            var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
            letterTyped.SendKeys("A");
            Thread.Sleep(1000);
            btnInsertLetter.Click();
        }

        [When(@"I entered G as the LetraIngresada")]
        public void WhenIEnteredGAsTheLetraIngresada()
        {
            var letterTyped = driver.FindElement(By.Id("inputletter"));
            var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
            letterTyped.SendKeys("G");
            Thread.Sleep(1000);
            btnInsertLetter.Click();
        }

        [When(@"I entered I as the LetraIngresada")]
        public void WhenIEnteredIAsTheLetraIngresada()
        {
            var letterTyped = driver.FindElement(By.Id("inputletter"));
            var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
            letterTyped.SendKeys("I");
            Thread.Sleep(1000);
            btnInsertLetter.Click();
        }

        [When(@"I entered L as the LetraIngresada")]
        public void WhenIEnteredLAsTheLetraIngresada()
        {
            var letterTyped = driver.FindElement(By.Id("inputletter"));
            var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
            letterTyped.SendKeys("L");
            Thread.Sleep(1000);
            btnInsertLetter.Click();
        }

        [When(@"I entered E as the LetraIngresada")]
        public void WhenIEnteredEAsTheLetraIngresada()
        {
            var letterTyped = driver.FindElement(By.Id("inputletter"));
            var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
            letterTyped.SendKeys("E");
            Thread.Sleep(1000);
            btnInsertLetter.Click();
        }

        [When(@"I entered S as the LetraIngresada")]
        public void WhenIEnteredSAsTheLetraIngresada()
        {
            var letterTyped = driver.FindElement(By.Id("inputletter"));
            var btnInsertLetter = driver.FindElement(By.Id("IntentarLetra"));
            letterTyped.SendKeys("S");
            Thread.Sleep(1000);
            btnInsertLetter.Click();
        }

        [Then(@"I should be told that I won the game")]
        public void ThenIShouldBeToldThatIWonTheGame()
        {
            var LabelGanar = driver.FindElement(By.Id("win"));
            Assert.AreEqual(LabelGanar.Text, "¡Ganaste!");
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}