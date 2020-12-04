using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using System.IO;
using System.Reflection;


namespace Azure_demo
{

    public class class2
    {
        [Test]
        public void SearchForWord2()
        {
            var driver = new ChromeDriver();

            {
                
                driver.Navigate().GoToUrl("https://www.google.com/");

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Name("q"));

                Thread.Sleep(5000);

                query.SendKeys("hola hola");

                Thread.Sleep(5000);

                driver.Quit();


            }
        }
    }
}
