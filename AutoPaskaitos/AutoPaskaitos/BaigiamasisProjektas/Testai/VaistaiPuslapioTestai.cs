using AutoPaskaitos.BaigiamasisProjektas.Puslapiai;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace AutoPaskaitos.BaigiamasisProjektas.Testai
{
    class VaistaiPuslapioTestai : Bazine //klasei "VaistaiPuslapioTestai", papildau klases "griauciais" is klases "Bazine". ((Dalis programos + GRIAUCIAI))
    {
        private Vaistai vaistai;        //Atminty sukuria tuscia vieta(kintamaji), tokio dydzio kaip "Vaistai". Kintamasis-"vaistai", jo dydi nusako ("Vaistai").
               
        /*Klase is didziosios raides
         * Kintamieji is mazuju raides
         * funkcijos/metodai pirma raide mazoji, sudurtiniam antras zodis gali but is didziosios arba mazosios
         * konstruktorius kaip klase - pasisavina
         */

        [SetUp]
        public void PriesKiekvienaTesta()
        {
            vaistai = new Vaistai(driver); //sukuria kintamaji (vaistai) ir iraso duomenis kuriuos paima is (Vaistai) ir papido konkrecia (driver) informacija is klases (Bazine).
                       
        }
        [Test]
        public void idetiVaistusikrepseli()//+
        {
            vaistai.IAkcijas();            
            vaistai.IdetiIKepseli();
            Thread.Sleep(3000);
            vaistai.IiKrepseli();
            Thread.Sleep(3000);
            vaistai.AtidarytiKrepseli();
            Thread.Sleep(3000);
            vaistai.SutikrintiVaistus();
        }
        [Test]//+
        public void nuolaida()
        {
            idetiVaistusikrepseli();            
            vaistai.TikrinamKitaLanga();
            vaistai.KlaidingasKodas();
            vaistai.PridetiButton();
            Thread.Sleep(3000);
            vaistai.KuponasNeegzistuoja();
        }
        /*[Test]
        public void arSugrisIVirsu()//neveikia
        {
            vaistai.NuleistiPuslapi();
            Thread.Sleep(5000);
            vaistai.PopupLangas();
            vaistai.Rodykle();
            vaistai.ArSugryzoIVirsu();
            
        }*/
        [Test]//+
        public void pristatytiIVaistine()
        {
            idetiVaistusikrepseli();
            vaistai.PristatytiIVaistineButton();
        }

        [Test]
        public void pirktiKaipSveciui()
        {
            //vaistai.idetiVaistusikrepseli();
            pristatytiIVaistine();
            Thread.Sleep(3000);
            vaistai.sPirktiKaipSveciui();
            Thread.Sleep(3000);
            vaistai.vardoLaukas();
            vaistai.pavardesLaukas();
            vaistai.pastoLaukas();
            vaistai.metuLaukas();
            Thread.Sleep(3000);
            vaistai.iapacia();
            Thread.Sleep(3000);
            vaistai.testiButton();
            Thread.Sleep(3000);
            vaistai.iApacia();
            Thread.Sleep(3000);
            vaistai.errorLangai();
        }


        [TearDown]
        public void PoKiekvienoTesto()
        {
            driver.Quit();
        }
    }
}
