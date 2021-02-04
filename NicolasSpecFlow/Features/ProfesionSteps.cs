using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicolasLogica;
using TechTalk.SpecFlow;


namespace NicolasSpecflow.Features
{
    [Binding]
    public class ProfesionSteps
    {
        Logica logica = new Logica();
        [Given(@"que el nombre es ""(.*)""")]
        public void DadoQueElPrimerNombreEs(string nombre)
        {
            logica.Nombre = nombre;
        }

        [Given(@"su apellido es ""(.*)""")]
        public void DadoElApellidoEs(string apellido)
        {
            logica.Apellido = apellido;
        }

        [When(@"los datos son")]
        public void CuandoLosDatosSon()
        {
            logica.DatosMedico();
        }

        [Then(@"el resultado debe sera ""(.*)""")]
        public void EntoncesElResultadoDebeSer(string esperado)
        {
            Assert.AreEqual(esperado, logica.Resultado);
        }

        [Given(@"que la profesion es ""(.*)""")]
        public void DadoQueLaProfesionEs(string profesion)
        {
            logica.Profesion = profesion;
        }

        [Given(@"al bufete al que pertence es ""(.*)""")]
        public void DadoElBufeteAlQuePertenceEs(string Bufete)
        {
            logica.Bufete = Bufete;
        }

        [When(@"sus datos de profesion son")]
        public void CuandoSusDatosDeProfesionSon()
        {
            logica.DatosDeLaProfesion();
        }

        [Then(@"el resultado es ""(.*)""")]
        public void EntoncesElResultadoEs(string esperado)
        {
            Assert.AreEqual(esperado, logica.Resultado); 
        }

    }
}