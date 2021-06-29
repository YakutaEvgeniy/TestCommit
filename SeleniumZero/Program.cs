using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            string text = driver.FindElement(By.ClassName("RNmpXc")).Text;
            Console.WriteLine("Hello eghwH"+text);
            driver.Quit();
        }
    }
}
