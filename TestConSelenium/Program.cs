using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestConSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl("https://www.youtube.com/");
                driver.FindElement(By.Name("search_query")).SendKeys("Google");
                driver.FindElement(By.Id("search-icon-legacy")).SendKeys(Keys.Enter);
                IWebElement buttonlog = driver.FindElement(By.XPath("/html/body/ytd-app/div/div/ytd-masthead/div[3]/div[3]/div[2]/ytd-button-renderer"));
                buttonlog.Click();
                driver.FindElement(By.Id("identifierId")).SendKeys("tucorreo@gmail.com");//Escribe el correo.
                IWebElement buttonnext = driver.FindElement(By.Id("identifierNext"));
                buttonnext.Click();
            }
        }
    }
}
