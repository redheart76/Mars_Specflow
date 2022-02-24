using System;
using Mars_Specflow.Helpers;
using Mars_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class ListingManagermentPage
    {
        public void assertTitleIsDisplayed()
        {
            Wait.WaitToBeVisible(Driver.driver, "Xpath", "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]", 2);
            //Assert whether the title text is displayed
            IWebElement titleText = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
            Assert.IsTrue(titleText.Displayed);

        }

        public void editSkill()
        {
            //Click on edit icon
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i")).Click();
        }

        public void deleteSkill()
        {
            //Click delete and accept
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")).Click();            
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]/i")).Click();
            

        }

        public void assertDeletion()
        {
            Wait.WaitToBeVisible(Driver.driver, "Xpath", "/html/body/div/div/div/div[2]/h3", 2);
            //Assert whether "You do not have any service listings!" is displayed
            IWebElement deletionText = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/h3"));
            Assert.IsTrue(deletionText.Displayed);
        }

       

        public void assertSkillDescriptionIsDisplayed()
        {
            Wait.WaitToBeVisible(Driver.driver, "Xpath", "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[4]", 2);
            //Assert whether new description is displayed
            IWebElement DescriptionText = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
            Assert.IsTrue(DescriptionText.Displayed);
        }
    }
}
