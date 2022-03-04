using System;
using Mars_Specflow.Helpers;
using Mars_Specflow.Utilities;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class ServiceListingPage
    {
        
       public static void newSkill()
       {
            //Type in new Title
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")).SendKeys("Web Design");

            //Type in description
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("Design and build the website from scratch.");

            //Click on category drop down menu
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div > select")).Click();

            //Select Graphics & Design
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select/option[2]")).Click();
            
            //Click on Subcategory
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select")).Click();

            //Select Search & Display Marketing
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[6]")).Click();

            //Add a new tag
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")).SendKeys("A" + "\n");

            //Select service type
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")).Click();

            //Select location type
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")).Click();

            //Select available start date
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")).SendKeys("01052022");

            //Select available end date
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")).SendKeys("04052022");

            //Select available day
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")).Click();

            //Select available start time
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")).SendKeys("0800am");

            //Select available end time
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")).SendKeys("0500pm");

            //Select skill trade status
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")).Click();

            //Add a tag to skill exchange
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")).SendKeys("B" + "\n");


            ////Add file

            //Select active status
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")).Click();
            
    }
        public static void editSkillDescription()
        {
            //Wait description text to be visable
            Wait.WaitToBeVisible(Driver.driver, "Xpath", "/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[1]/h3", 2);

            //Edit the description
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).Clear();
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("Design and build the website from scratch,Front end and back end development. ");
        }

        public static void saveSkill()
        {
            //Click on the save button to save the changes
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[11]/div/input[1]")).Click();
            
        }

       
    }
}
