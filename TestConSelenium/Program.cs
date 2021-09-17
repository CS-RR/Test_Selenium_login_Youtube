using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestConSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl("https://www.youtube.com/");
                driver.FindElement(By.Name("search_query")).SendKeys("Google");
                driver.FindElement(By.Id("search-icon-legacy")).SendKeys(Keys.Enter);
                IWebElement bottonlog = driver.FindElement(By.XPath("/html/body/ytd-app/div/div/ytd-masthead/div[3]/div[3]/div[2]/ytd-button-renderer"));
                bottonlog.Click();
                driver.FindElement(By.Id("identifierId"));

            }
        }
    }
}
