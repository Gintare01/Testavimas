using AutoPaskaitos.BaigiamasisProjektas.Puslapiai;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class PagrindinioPuslapioTestai : Bazine
    {
          
        private PagrindinisPuslapis pagrindinisPuslapis;

        [SetUp]
        public void PriesKiekvienaTesta()
        {
            pagrindinisPuslapis = new PagrindinisPuslapis(driver);
        }
        [Test]
        public void akcijosLangas()
        {
            pagrindinisPuslapis.PaspauskAkcijosMygtuka();
            Thread.Sleep(5000);
            pagrindinisPuslapis.PatikrinkAkcijosLanga();
        }

        [Test]
        public void arAtidarysFacebook()//atidaro bet nezinau ar nuskaito
        {
            pagrindinisPuslapis.IApaciaPuslapio();
            pagrindinisPuslapis.PaspauskFacebookMygtukas();
            Thread.Sleep(3000);
            pagrindinisPuslapis.PopupOut();
            
            pagrindinisPuslapis.ArNaujameLangeFb();
        }

        [Test]
        public void arUzpPrenumeruos()
        {
            driver.Url = "https://camelia.lt/";
            pagrindinisPuslapis.iApaciascroll();
            Thread.Sleep(5000);
            pagrindinisPuslapis.IrasykEmaila();
            pagrindinisPuslapis.PaspauskPrenumeratosMygtuka();
            Thread.Sleep(5000);
            pagrindinisPuslapis.PatikrintiIsmestaLanga();
        }
        [Test]
        public void arAtidareAkims()//+
        {
            pagrindinisPuslapis.ImituokPelesUzvedimaVitaminai();
            pagrindinisPuslapis.PaspauskAntAkims();
            Thread.Sleep(3000);
            pagrindinisPuslapis.ArAtitinkaAkims();
        }


        [TearDown]
        public void PoKiekvienoTesto()
        {
            driver.Quit();
        }
    }

}
