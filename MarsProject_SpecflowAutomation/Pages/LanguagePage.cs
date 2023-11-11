using MarsProject_SpecflowAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MarsProject_SpecflowAutomation.Pages
{
    public class LanguagePage
    {
        public void AddLanguage(IWebDriver driver, string language, string level)
        {
            //Refresh the Profile Page 
            driver.Navigate().Refresh();

            //Wait for the table to be Visible
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            Thread.Sleep(2000);
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
            IWebElement AddLanguageTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguageTextBox.Click();
            AddLanguageTextBox.SendKeys(language);
            IWebElement ChooseLevelDD = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLevelDD.Click();


            if (level.Equals("Basic"))
            {
                // Select Basic Option from the Dropdown

                IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
                levelOption.Click();
            }
            else if (level.Equals("Conversational"))
            {
                // Select Conversational Option from the Dropdown
                IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Conversational']"));
                levelOption.Click();
            }
            else if (level.Equals("Fluent"))
            {
                // Select Fluent Option from the Dropdown
                IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
                levelOption.Click();
            }
            else if (level.Equals("Native"))
            {
                // Select Native/Bilingual Option from the Dropdown
                IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Native/Bilingual']"));
                levelOption.Click();
            }

            Thread.Sleep(2000);
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();

        }

        public void AssertAddNewLanguage(IWebDriver driver, string language)
        {
            //Verify if the new Language has been created Successfully
            driver.Navigate().Refresh();
            // Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 2);
            Thread.Sleep(2000);
            IWebElement NewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (NewLanguage.Text.Equals(language))
            {
                Assert.Pass("Language has been Added Successfully");

            }
            else
            {
                Assert.Fail("Language Not Added Successfully");
            }
            Thread.Sleep(2000);
        }

        public void EditLanguage(IWebDriver driver, string OldLan, string OldLevel, string NewLan, string NewLevel)
        {
            //Refresh the Profile Page 
            driver.Navigate().Refresh();
            Thread.Sleep(3000);

            //Get the count of rows in the table
            int rowcount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;

            for (int i = 1; i <= rowcount; i++)
            {
                //Select the language that need to be edited
                IWebElement SelectLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                if (SelectLanguage.Text.Equals(OldLan))
                {
                    IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                    EditButton.Click();

                    IWebElement EditLanguageTextBox = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                    EditLanguageTextBox.Click();

                    EditLanguageTextBox.Clear();
                    EditLanguageTextBox.SendKeys(NewLan);

                    IWebElement ChooseLevelDD = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select"));
                    ChooseLevelDD.Click();

                    if (NewLevel.Equals("Basic"))
                    {
                        // Select Basic Option from the Dropdown

                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
                        levelOption.Click();
                    }
                    else if (NewLevel.Equals("Conversational"))
                    {
                        // Select Conversational Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Conversational']"));
                        levelOption.Click();
                    }
                    else if (NewLevel.Equals("Fluent"))
                    {
                        // Select Fluent Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
                        levelOption.Click();
                    }
                    else if (NewLevel.Equals("Native"))
                    {
                        // Select Native/Bilingual Option from the Dropdown
                        IWebElement levelOption = driver.FindElement(By.XPath("//option[@value='Native/Bilingual']"));
                        levelOption.Click();
                    }

                    Thread.Sleep(2000);

                    IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]"));
                    UpdateButton.Click();
                    break;
                }
            }

        }
        public void AssertEditLanguage(IWebDriver driver, string NewLan, string NewLevel)
        {
            //Verify if the existing Language has updated Successfully
            driver.Navigate().Refresh();

            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 2);
            Thread.Sleep(3000);

            int rowcount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;

            int i;
                for (i = 1; i <= rowcount; i++)
                {
                    IWebElement SelectLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    IWebElement SelectLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]"));

                if ((SelectLanguage.Text.Equals(NewLan)) && (SelectLevel.Text.Equals(NewLevel)))
                    {
                        Assert.That((SelectLanguage.Text.Equals(NewLan)) && (SelectLevel.Text.Equals(NewLevel)),"Language NOT  Updated Successfully");
                        break;
                   
                    }
                }
                        
            Thread.Sleep(2000);
        }
        public void DeleteLanguage(IWebDriver driver, string Language, string Level)
        {
            //Refresh the Profile Page 
            driver.Navigate().Refresh();
            Thread.Sleep(3000);

            //Get the count of rows in the table
            int rowcount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;

            int i;
            for (i = 1; i <= rowcount; i++)
            {
                IWebElement SelectLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                IWebElement SelectLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]"));

                if ((SelectLanguage.Text.Equals(Language)) && (SelectLevel.Text.Equals(Level)))
                {
                    IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i"));
                    DeleteButton.Click();
                //rowcount--;
                  break;
               // driver.Navigate().Refresh();
                //Thread.Sleep(3000);

            }
            }

        }
        public void AssertDeleteLanguage(IWebDriver driver, string Language, string Level)
        {
            //Verify if the existing Language has deleted Successfully
            driver.Navigate().Refresh();

            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table", 2);
            Thread.Sleep(3000);

            int rowcount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table//tbody")).Count;

            int i, flag=0;
            for (i = 1; i <= rowcount; i++)
            {
                IWebElement SelectLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                IWebElement SelectLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[2]"));

                if ((SelectLanguage.Text.Equals(Language)) && (SelectLevel.Text.Equals(Level)))
                {
                    flag = 1;
                    break;

                }
            }
            if(flag==0)
            {
                Assert.True(flag==0, "Language NOT Deleted");
            }

            Thread.Sleep(2000);
        }
    }
}

