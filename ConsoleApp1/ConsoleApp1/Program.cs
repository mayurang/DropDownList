using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            // driver.FindElement(By.XPath("//*[@id='nav-link-shopall']/span[2]/span")).Click();
            // driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Hello");

            //IWebElement month_dropdown = driver.FindElement(By.Id("month"));

            var day = driver.FindElement(By.Id("day"));
            var select_day = new SelectElement(day);
            select_day.SelectByValue("2");

            var month = driver.FindElement(By.Id("month"));
            var select_month = new SelectElement(month);
            select_month.SelectByText("Apr");




            Thread.Sleep(10000);

            driver.Quit();
        }
    }
}
