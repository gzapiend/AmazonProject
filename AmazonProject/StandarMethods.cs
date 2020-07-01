using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AmazonProject
{
    public class StandartMethods
    {
        IWebDriver webDriver;
        public void Init_Browser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;

        }
        public void Close()
        {
            webDriver.Quit();
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }

        public void Click(By element) {
            webDriver.FindElement(element).Click();
        }

        public void SendKeys(By element, string value) {
            webDriver.FindElement(element).SendKeys(value);
        }

        public static bool EWait(this IWebDriver driver, By by)
        {
            try
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(by))
                //driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}