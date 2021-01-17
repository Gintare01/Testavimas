using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.BaigiamasisProjektas.Puslapiai
{
    class Vaistai : BazinePuslapiu
    {
        public Vaistai(IWebDriver driver) : base(driver) { }

        private IWebElement iAkcijas => driver.FindElement(By.CssSelector(".mm11 span"));
        private IWebElement akimsNuoroda => driver.FindElement(By.CssSelector(".mm3 > .amenu-link > span"));
        private IWebElement pirktiButton => driver.FindElement(By.CssSelector(".product-miniature:nth-child(1) .grid-buy-button span"));
        //private IWebElement pirktiButton => driver.FindElement(By.CssSelector(".product-miniature:nth-child(1) .img-fluid"));
        private IWebElement iKrepseli => driver.FindElement(By.CssSelector(".btn > span:nth-child(2)"));        
        private IWebElement iiKrepseli => driver.FindElement(By.CssSelector("#js-cart-sidebar .cart-bottom .btn"));
        private IWebElement nuolaida => driver.FindElement(By.Name("discount_name"));
        private IWebElement pridetiButton => driver.FindElement(By.CssSelector(".btn > span"));
        private IWebElement kuponasNetiko => driver.FindElement(By.CssSelector(".js-error"));
        private IWebElement rodyklyte => driver.FindElement(By.CssSelector(".fa-angle-double-up"));
        private IWebElement iVaistine => driver.FindElement(By.Name("orderPickupStore"));
        private IWebElement logo => driver.FindElement(By.ClassName("logo"));
        private IWebElement popup => driver.FindElement(By.Id("index"));


        private IWebElement pirktiKaipSveciui => driver.FindElement(By.CssSelector("#checkout-login-form .js-switch-personal-form"));
        private IWebElement vardas => driver.FindElement(By.Name("firstname"));
        private IWebElement pavarde => driver.FindElement(By.Name("lastname"));
        private IWebElement mail => driver.FindElement(By.CssSelector(".form-group:nth-child(4) .form-control"));
        private IWebElement metai => driver.FindElement(By.Name("birthday"));
        //private IWebElement tel => driver.FindElement(By.Name("phone"));
        private IWebElement testi => driver.FindElement(By.CssSelector(".continue:nth-child(1)"));
        private IWebElement errormail => driver.FindElement(By.CssSelector(".email .alert"));
        private IWebElement errormetai => driver.FindElement(By.CssSelector(".help-block:nth-child(3) .alert"));
        private IWebElement errortel => driver.FindElement(By.CssSelector(".phone .alert"));
        

        public void RaskAkimsNuoroda()
        {
            //akimsNuoroda.FindElement;

            var element = driver.FindElement(By.CssSelector(".dd5 li:nth-child(1) span"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        public void IAkcijas()
        {
            iAkcijas.Click();
        }
        public void IdetiIKepseli()
        {
            pirktiButton.Click();
        }
        public void IiKrepseli()
        {

            iKrepseli.Click(); 
        }
        public void AtidarytiKrepseli()
        {
            iiKrepseli.Click();
        }
        
        public void SutikrintiVaistus()
        {         
            Assert.AreEqual("Gelis paakiams BIODERMA SENSIBIO raminamasis 15ml", driver.FindElement(By.LinkText("Gelis paakiams BIODERMA SENSIBIO raminamasis 15ml")).Text);            
        }
        public void TikrinamKitaLanga()
        {
            driver.Url = "https://camelia.lt/krepselis?action=show";        
        }
        public void KlaidingasKodas()
        {
            nuolaida.SendKeys("l");
        }
        public void PridetiButton()
        {
            pridetiButton.Click();
        }
        public void KuponasNeegzistuoja()
        {
            //Assert.IsTrue(driver.FindElement(By.CssSelector(".js-error")).Displayed);
            Assert.AreEqual("Kuponas neegzistuoja.", driver.FindElement(By.CssSelector(".js-error-text")).Text);
        }
        public void NuleistiPuslapi()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 20)");
        }
        public void PopupLangas()
        {
            popup.Click();
        }
        public void Rodykle()
        {
            rodyklyte.Click();
        }
        public void ArSugryzoIVirsu()
        {
            Assert.IsTrue(driver.FindElement(By.ClassName("logo")).Displayed);
        }
        public void PristatytiIVaistineButton()
        {
            iVaistine.Click();
        }




        public void sPirktiKaipSveciui()
        {
            pirktiKaipSveciui.Click();
        }
        public void vardoLaukas()
        {
            vardas.SendKeys("gi");
        }
        public void pavardesLaukas()
        {
            pavarde.SendKeys("ma");
        }
        public void pastoLaukas()
        {
            mail.SendKeys("si@si");
        }
        public void metuLaukas()
        {
            metai.SendKeys("5");
        }
        public void iapacia()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight -200)");
        }
        public void iApacia()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight -100)");           
        }
        public void testiButton()
        {
            testi.Click();
        }
        public void errorLangai() //error mail,metai,tel
        {
            Assert.AreEqual("Neteisingas formatas.", driver.FindElement(By.CssSelector(".email .alert")).Text);
            Assert.AreEqual("Formatas turi būti 1970-05-31.", driver.FindElement(By.CssSelector(".help-block:nth-child(3) .alert")).Text);
            Assert.AreEqual("Neteisingas formatas.", driver.FindElement(By.CssSelector(".phone .alert")).Text);
        }


    }
}
