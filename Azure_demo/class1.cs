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
    
    public class class1
    {
        [Test]
        public void SearchForWord()
        {
            var driver = new ChromeDriver();

            {
                FileStream file = new FileStream(@"D:\a\1\s\Book1.xlsx", FileMode.Open, FileAccess.Read);
                XSSFWorkbook workbook = new XSSFWorkbook(file);
                ISheet sheet = workbook.GetSheet("Sheet1");

                var value = string.Format(sheet.GetRow(0).GetCell(0).StringCellValue);

                //Notice navigation is slightly different than the Java version
                //This is because 'get' is a keyword in C#
                driver.Navigate().GoToUrl("http://www.google.com/");

                // Find the text input element by its name
                IWebElement query = driver.FindElement(By.Name("q"));

                Thread.Sleep(5000);

                query.SendKeys(value);

                Thread.Sleep(5000);

                string check_value = query.GetAttribute("value");

                Console.WriteLine(check_value + " coming from test 1 ");

                driver.Quit();


            }
        }
    }
}
