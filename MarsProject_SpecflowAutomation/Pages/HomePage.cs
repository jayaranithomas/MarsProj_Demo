using MarsProject_SpecflowAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecflowAutomation.Pages
{
    public class HomePage
    {
        public void SignInAction(IWebDriver driver)
        {
            //navigate to the Mars portal login page
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //maximize the window
            driver.Manage().Window.Maximize();

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 5);

            IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignInButton.Click();
        }
    }
}
