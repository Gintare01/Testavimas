using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoPaskaitos.BaigiamasisProjektas.Puslapiai
{
    class PagrindinisPuslapis : BazinePuslapiu
    {
        public PagrindinisPuslapis(IWebDriver driver) : base(driver) { }

        private IWebElement akcijosMygtukas => driver.FindElement(By.CssSelector(".mm11 span"));        
        private IWebElement FacebookMygtukas => driver.FindElement(By.CssSelector(".facebook"));
        private IWebElement PrenumeratosMygtukas => driver.FindElement(By.Name("submitNewsletter"));
        private IWebElement IvedimoLaukas => driver.FindElement(By.Name("email"));        
        private IWebElement akimsNuoroda => driver.FindElement(By.CssSelector("#amegamenu > ul > li.amenu-item.mm3.plex > div > div > div.dropdown-content.acot1.dd5 > div > div > ul > li:nth-child(1) > a > span"));
        


        public void PaspauskAkcijosMygtuka()
        {
            akcijosMygtukas.Click();
        }
        public void PatikrinkAkcijosLanga()
        {            
            Assert.AreEqual("AKCIJOS", driver.FindElement(By.CssSelector(".page-heading")).Text);
        }
        public void PaspauskFacebookMygtukas()
        {
            Thread.Sleep(6000);
            FacebookMygtukas.Click();
        }
        public void PopupOut()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='u_0_20']")).Click();
            }
            catch (WebDriverException)
            {

            }
        }
        public void IApaciaPuslapio()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");            
        }
        
        public void ArNaujameLangeFb()
        {
            //Store the ID of the original window
            //string originalWindow = driver.CurrentWindowHandle;
                        
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Check we don't have other windows open already
            Assert.AreEqual(driver.WindowHandles.Count, 2);

            //Click the link which opens in a new window
           // driver.FindElement(By.LinkText("new window")).Click();

            var newWindowHandle = driver.WindowHandles[1];
            driver.SwitchTo().Window(newWindowHandle);

            //Wait for the new window or tab
           // wait.Until(wd => wd.WindowHandles.Count == 2);

            //Loop through until we find a new window handle

           // driver.SwitchTo().Window(window);

            //Wait for the new tab to finish loading content
            //wait.Until(wd => wd.Title == "Selenium documentation");

            Assert.AreEqual("https://www.facebook.com/camelia.vaistine", driver.Url);
        }        
        public void IrasykEmaila()
        {            
            IvedimoLaukas.SendKeys("lisa@gmail.com");            
        }
        public void iApaciascroll()
        {            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight -50)");
        }
        public void PaspauskPrenumeratosMygtuka()
        {
            PrenumeratosMygtukas.Click();
        }
        public void PatikrintiIsmestaLanga()
        {            
            Assert.AreEqual("Jūs sėkmingai užsiprenumeravote šį naujienlaiškį.", driver.FindElement(By.CssSelector(".alert-success")).Text);
        }
        public void ImituokPelesUzvedimaVitaminai()
        {
            var element = driver.FindElement(By.CssSelector(".mm3 > .amenu-link > span"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Build().Perform();            
        }
        public void PaspauskAntAkims()
        {
            akimsNuoroda.Click();
        }
        public void ArAtitinkaAkims()
        {
            //Assert.AreEqual("AKIMS", driver.FindElement(By.CssSelector(".breadcrumb-item:nth-child(3) > a > span")).Text);
            Assert.AreEqual("https://camelia.lt/1513-akims/", driver.Url);
        }

    }

}
