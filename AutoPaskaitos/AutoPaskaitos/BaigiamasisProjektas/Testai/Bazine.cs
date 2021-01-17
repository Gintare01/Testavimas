using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class Bazine
    {
        public IWebDriver driver;

        [SetUp]
        public void priesKiekvienaTesta()
        {
            PerduotiDriveri("crome");
            driver = new ChromeDriver();
            driver.Url = "https://camelia.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
            try
            {
                driver.FindElement(By.CssSelector("#index")).Click();
            }
            catch (WebDriverException)
            {

            }


        }
        public void PerduotiDriveri(string driverPavadinimas)
        {
            if(driverPavadinimas == "chrome")
            {
                driver = new ChromeDriver(GautiChromoPradinesKonfiguracijas());
            }
            if(driverPavadinimas == "firefox")
            {
                driver = new FirefoxDriver();
            }

            //private IWebElement csslokatoriauspavyzdys => driver.FindElement(By.CssSelector("[for='kazkokiaReiksme']"));
        }
        public ChromeOptions GautiChromoPradinesKonfiguracijas()
        {
            ChromeOptions konfiguracijos = new ChromeOptions();
            konfiguracijos.AddArguments("start maximized", "incognito");
            return konfiguracijos;
        }
    [TearDown]
        public void poKiekvienoTesto()
        {
            driver.Quit();
        }
    }
}
