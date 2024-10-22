using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Mereo.Domain.Test
{
    public class UrlGoogleAutomaticTest : IDisposable
    {
        private readonly IWebDriver webDriver;
        private readonly WebDriverWait webDriverWait;
        public UrlGoogleAutomaticTest()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless"); //tornar o processo mais rapido, pois não preciso visualizar a interação do navegador.
            webDriver = new ChromeDriver(options);
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        // Metodo para ver se o titulo é valido;
        public bool TestarTituloGoogle()
        {
           try 
           {
                webDriver.Navigate().GoToUrl("https://google.com");
                webDriverWait.Until(d => d.Title.Contains("Google"));

                string pageTitle = webDriver.Title;

                return pageTitle.Contains("Google", StringComparison.OrdinalIgnoreCase);
           } 
           catch
           {
                return false;
           }
        }
        public void Dispose()
        {
            webDriver.Quit();
        }
    }
}