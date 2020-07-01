using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AmazonProject.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://amazon.com");
        }
    }
}
