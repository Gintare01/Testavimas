/*using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoPaskaitos._1Auto
{
    class IvedimoLaukuTestai
    {
        [Test]
        public void RodykZinute()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("cricle-btn")).Click();

            string irasomasTekstas = "Tekst";

            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
            driver.FindElement(By.Id("user-message")).SendKeys(irasomasTekstas);
            driver.FindElement(By.CssSelector("#get-input button")).Click();
            
            Assert.AreEqual(irasomasTekstas, driver.FindElement(By.Id("display")).Text);
        }
        [Test]
        public void ApskaiciuokSuma()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();

            driver.FindElement(By.Id("sum1")).SendKeys("10");
            driver.FindElement(By.Id("sum2")).SendKeys("5");
            driver.FindElement(By.CssSelector("#gettotal button")).Click();

            Assert.AreEqual("15", driver.FindElement(By.Id("displayvalue")).Text);
        }
        public void UzkroveSimtuProcentu()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/bootstrap-download-progress-demo.html";
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);

            driver.FindElement(By.Id("cricle-btn")).Click();


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(
                ExpectedConditions.TextToBePresentInElement(driver.FindElement(By.ClassName("percenttext")), "100%"));

            Assert.AreEqual("100", driver.FindElement(By.ClassName("precenttext")).Text);
            /*
            1) Thread.Sleep(milisekundes);
            2) Implicitly wait -> driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            3) Explicitly wait ->WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(
                ExpectedConditions.TextToBePresentInElement(driver.FindElement(By.ClassName("percenttext")), "100%"));
            4) Fluent Wait
            *//*
            Assert.AreEqual("100", driver.FindElement(By.Id("atsijungti")).Displayed);
            Assert.IsTrue(driver.FindElement(By.Id("atsijungti")).Displayed);
        }
        [Test]
        public void LangelisCheckbox()
        {/*
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("isAgeSelected")).Click();
        *//*
        }
        [Test]
        public void PatikrinkArVisiCheckboxPazymeti()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("at-cv-lightbox-close")).Click();

            var checkboxai = driver.FindElements(By.ClassName("cb1-element"));
            var checkboxas = driver.FindElement(By.ClassName("cb1-element"));


            foreach (var checkboxElementas in checkboxai)
            {
                checkboxElementas.Click();
                Thread.Sleep(2000);
            }

            checkboxas.Click();


            foreach (var checkboxElementas in checkboxai)
            {
                Assert.IsTrue(checkboxElementas.Selected);
            }


        }








    }
}*/
