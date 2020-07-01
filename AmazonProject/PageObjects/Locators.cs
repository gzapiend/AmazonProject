using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonProject
{
    class Locators
    {
        //Login
        public static By UserName = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/div/div/form/div[1]/div/input");
        public static By Password = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/div/div/form/div[2]/div/div/input");
        public static By LoginBtn = By.CssSelector("#submit");
    }
}
