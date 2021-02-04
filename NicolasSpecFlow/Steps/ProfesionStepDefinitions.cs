using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace NicolasAppWeb.Steps
{
    [Binding]
    public sealed class ProfesionStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver = new FirefoxDriver();

        public ProfesionStepDefinitions(ScenarioContext scenarioContext)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://localhost:59767");
        }

        [Given("el nombre es (.*)")]
        public void DadoQueElNombreEs(string nombre)
        {
            driver.FindElement(By.Name("nombre")).SendKeys(nombre.ToString());
        }

        [Given("el apellido es (.*)")]
        public void DadoElApellidoEs(string apellido)
        {
            driver.FindElement(By.Name("apellido")).SendKeys(apellido.ToString());
        }

        [When("los datos son ")]
        public void CuandoLosDatosSon()
        {
            driver.FindElement(By.Name("generar")).Click();
        }

        [Then("el resultado debe ser  (.*)")]
        public void ThenTheResultShouldBe(string esperado)
        {
            var respuesta = driver.FindElement(By.Name("respuesta")).Text;
            Assert.AreEqual(esperado, respuesta);
        }
    }
}

