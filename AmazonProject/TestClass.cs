using AmazonProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonProject
{
    class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void GermanTesting()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            driver.FindElement(Locators.UserName);
            //AboutPage about = home.goToAboutPage();
            //ResultPage result = about.search("selenium c#");
            //result.clickOnFirstArticle();
            Assert.IsTrue();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
