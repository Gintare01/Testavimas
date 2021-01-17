using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.BaigiamasisProjektas.Puslapiai
{
    class PrisijungimoPuslapis : BazinePuslapiu
    {
        public PrisijungimoPuslapis(IWebDriver driver) : base(driver) { }

        //private IWebElement prisijungti => driver.FindElement(By.Id("submit-login"));
        private IWebElement pamirsoPass => driver.FindElement(By.LinkText("lock_open Pamiršote slaptažodį?"));
        private IWebElement ivestMaila => driver.FindElement(By.Id("email"));
        private IWebElement siustiAtstatymoNuoroda => driver.FindElement(By.Name("submit"));
        //private IWebElement patvirtinimoZinute => driver.FindElement(By.XPath("//*[@id='main']/ul/li/p/text()"));

        public void PrisijungtiButton()
        {            
            //prisijungti.Click();
            pamirsoPass.Click();                       
        }
        public void UzpildymoLaukas()
        {           
            ivestMaila.SendKeys("gi@gi.com");
        }
        public void AtstatymoButton()
        {
            siustiAtstatymoNuoroda.Click();
        }
        public void IssiustaImail()
        {
            Assert.AreEqual("Jei šis el. paštas buvo užregistruotas el. parduotuvėje, gausite nuorodą į gi@gi.com slaptažodžio atsatymui.", driver.FindElement(By.CssSelector("p:nth-child(2)")).Text);
        }
    }
}
