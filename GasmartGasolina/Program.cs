using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasmartGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var driver = new FirefoxDriver();
            driver.Url = "http://www.gasmart.mx/";
            driver.Navigate();

            IWebElement magna = driver.FindElement(By.Id("input_8_2"));
            var precioMagna = magna.GetAttribute("placeholder");

            Console.WriteLine("El precio de la gasolina Magna es: " + precioMagna);


            /**************/

            var premium = driver.FindElement(By.Id("input_8_3"));
            var precioPremium = premium.GetAttribute("placeholder");

            Console.WriteLine("El precio de la gasolina premium es: " + precioPremium);

            /***********/

            var disel = driver.FindElement(By.Id("input_8_7"));
            var precioDisel = disel.GetAttribute("placeholder");

            Console.WriteLine("El precio del disel es:" + precioDisel);
        }
    }
}
