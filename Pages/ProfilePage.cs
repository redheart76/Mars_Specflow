using System;
using System.Threading;
using Mars_Specflow.Helpers;
using Mars_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Mars_Specflow.Pages
{
    public class ProfilePage
    {
        public void gotoServiceListing()
        {

            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);

            //Click share skill button
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a")).Click();


        }

        public static void gotoListingManagementPage()
        {
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);

            //Click on manager listings tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[3]")).Click();

            // Wait edit icon to be clickable
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i", 3);
        }

        public static void gotoReceivedRequestPage()
        {
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);

            //Hover the mouse on the Manager Request tab to display the menu
            Actions actions = new Actions(Driver.driver);
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Manage Requests']"));
            actions.MoveToElement(uiDropdown).Perform();

            //Click on Received Request
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[1]/div/a[1]")).Click();

        }

        public static void gotoSentRequestPage()
        {
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);

            //Hover the mouse on the Manager Request tab to display the menu
            Actions actions = new Actions(Driver.driver);
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Manage Requests']"));
            actions.MoveToElement(uiDropdown).Perform();

            //Click on Sent Request
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/section[1]/div/div[1]/div/a[2]")).Click();
        }

        public static void personalDetails()
        {
            //Click on Availability edit button
            Driver.driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']")).Click();

            //Click drop down arrow
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select")).Click();

            //Select full time
            Driver.driver.FindElement(By.XPath("//option[@value='1']")).Click();

            //Click Hours edit button
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i")).Click();

            //Click drop down arrow
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select")).Click();

            //Select "More than 30 hours a week"
            Driver.driver.FindElement(By.XPath("//option[@value='1']")).Click();


            //Click earn target edit
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i")).Click();

            //Select "More than 30 hours a week"
            Driver.driver.FindElement(By.XPath("//option[@value='2']")).Click();

        }

        public static void addLanguage()
        {
            //Click Add New button to add new language
            Driver.driver.FindElement(By.XPath("//table[@class='ui fixed table']//tr/th[3]/div")).Click();

            //Add one of my languages
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Chinese");

            //Click the drop down menu of level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

            //Select my lanaguage level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[5]")).Click();

            //Click add button to save my selection
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

        }

        public static void addSkill()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

            //Click on Add button to add new skill
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Enter you skill
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Web Development");

            //Click on dropdown menu
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Select one of the options
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")).Click();

            //Click on Save button to save the skill
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

        public static void addEducation()
        {
            //Click on Education tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

            //Enter Uni name
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).Clear();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys("Auckland University");

            //Click to select Country
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]")).Click();

            //Click to select Title
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).Click();
            Driver.driver.FindElement(By.XPath("//select[@name='title']/option[@value='B.A']")).Click();

            //Enter the type of Degree
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).Clear();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Bachelor");

            //Click to select the Year of Education
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[10]")).Click();

            //Click on Add button to add education info
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

        }


        public static void assertEduAdded()
        {

            //Assert Uni name has bee added
            IWebElement UniNameTxt = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.IsTrue(UniNameTxt.Displayed);
        }

        public static void addCert()
        {
            //Click on Certifcation tab
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();

            //Enter Cert details
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Web development diploma");

            //Enter Cert was issued from
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("Polytechnic");

            //Click to select issued year
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]")).Click();

            //Click on Add button to add a new certificate
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
        }

        public static void addDescription()
        {
            //Click on Descripton edit icon
            Driver.driver.FindElement(By.XPath("//span[@class='button']/i")).Click();

            //Enter Description
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).Clear();
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).SendKeys("Hi, I have a bunch of skills that can be swapped with you.");

            //Click on the Save button to save the description
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

        }

        public static void changePassword()
        {
            Actions actions = new Actions(Driver.driver);

            //Hover the mouse and waiting for the menu to be displayed 
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Sam']"));
            actions.MoveToElement(uiDropdown).Perform();

            //Click on change password
            Driver.driver.FindElement(By.XPath("//*[text()='Change Password']")).Click();

            //Enter old password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input")).SendKeys("123123");

            //Enter new password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input")).SendKeys("456456");

            //Confirm new password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input")).SendKeys("456456");

            //Click on save button to save the new password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button")).Click();

            //Change the new password back to old password for further login purpose
            actions.MoveToElement(uiDropdown).Perform();
            Driver.driver.FindElement(By.XPath("//*[text()='Change Password']")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input")).SendKeys("456456");
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input")).SendKeys("123123");
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input")).SendKeys("123123");
            //Click on save button to save the new password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button")).Click();

        }

        //Click on Search icon
        public static void gotoSearchPage()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[1]/i")).Click();
          
        }

        //Go to the notification page
        public void gotoNotificationPage()
        {
            Actions actions = new Actions(Driver.driver);

            //Hover the mouse and waiting for the menu to be displayed 
            IWebElement notificationDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Notification']"));
            actions.MoveToElement(notificationDropdown).Perform();
            //Wait list to display
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "//*[text()='See All...']", 2);
            //Click on See All
            Driver.driver.FindElement(By.XPath("//*[text()='See All...']")).Click();
        }
    }
}

