using MarsProject_SpecflowAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject_SpecflowAutomation.Pages
{
    public class ProfilePage
    {
        public void SelectLanguage(IWebDriver driver, string selectTab)
        {

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 2);

            if (selectTab == "language")
            {
                IWebElement languageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
                languageTab.Click();
            }

           else if (selectTab == "skills")
            {
                IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                skillTab.Click();
            }

        }
    }
}
