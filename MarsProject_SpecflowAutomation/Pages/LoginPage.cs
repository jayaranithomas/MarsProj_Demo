using MarsProject_SpecflowAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecflowAutomation.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 2);

            IWebElement emailIdTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailIdTextBox.Click();
            emailIdTextBox.Clear();
            emailIdTextBox.SendKeys("jayaranithomas@gmail.com");
            IWebElement passWordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passWordTextBox.Click();
            passWordTextBox.Clear();
            passWordTextBox.SendKeys("123123");
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }
    }
}
