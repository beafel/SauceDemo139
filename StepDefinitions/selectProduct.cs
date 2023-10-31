using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver; // objeto do Selenium

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            // Instanciando o ChromeDriver através do WebDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            // Instanciou o Selenium como Chrome
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }


        [Given(@"que acesso a pagina inicial do site")]
        public void GivenQueAcessoAPaginaInicialDoSite()
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void WhenPreenchoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)"" e clico no botão Login")]
        public void WhenASenhaEClicoNoBotaoLogin(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void WhenAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"clico no icone do carrinho de compras")]
        public void WhenClicoNoIconeDoCarrinhoDeCompras()
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da secao")]
        public void ThenExibeNoTituloDaSecao(string products0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"verifico o titulo da secao ""(.*)""")]
        public void ThenVerificoOTituloDaSecao(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"a quantidade ""(.*)""")]
        public void ThenAQuantidade(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o produto ""(.*)""")]
        public void ThenOProduto(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o valor ""(.*)""")]
        public void ThenOValor(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}