using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NPOI.SS.UserModel;
using System.Threading;
using NPOI.Util;
using NPOI.XSSF.UserModel;
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
<<<<<<< HEAD
                FileStream file = new FileStream(@"D:\a\1\s\Book1.xlsx", FileMode.Open, FileAccess.Read);
                XSSFWorkbook workbook = new XSSFWorkbook(file);
                ISheet sheet = workbook.GetSheet("Sheet1");

                var value = string.Format(sheet.GetRow(0).GetCell(0).StringCellValue);

                driver.Navigate().GoToUrl("https://testmvcindia.azurewebsites.net/test.html");
=======
                
                driver.Navigate().GoToUrl("https://www.google.com/");
>>>>>>> 3826ecb49a54d22faca107172fc9f60ac331bd70

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Name("fname"));

                Thread.Sleep(5000);

                query.SendKeys(value);

                Thread.Sleep(2000);

                string check_value = query.GetAttribute("value");

                Console.WriteLine(check_value + "coming from azure webapp");



                Thread.Sleep(5000);

                driver.Quit();


            }
        }
    }
}
