using AutoPaskaitos.BaigiamasisProjektas.Puslapiai;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class PrisijungimoPuslapioTestai : Bazine
    {
        private PrisijungimoPuslapis prisijungimui;

        [SetUp]
        public void PriesKiekvienaTesta()
        {
            prisijungimui = new PrisijungimoPuslapis(driver);
            driver.Url = "https://camelia.lt/prisijungti?back=my-account";
        }
        [Test]
        public void PamirsoSlaptazodi()
        {
            prisijungimui.PrisijungtiButton();
            Thread.Sleep(3000);
            prisijungimui.UzpildymoLaukas();
            prisijungimui.AtstatymoButton();
            Thread.Sleep(3000);
            prisijungimui.IssiustaImail();
        }

        [TearDown]
        public void PoKiekvienoTesto()
        {
            driver.Quit();
        }
    }
}
