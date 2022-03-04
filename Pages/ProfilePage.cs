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
        //Add a skill to share
        public static void gotoServiceListing()
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

        public static void ReceivedRequestDropDown()
        {
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);

            //Hover the mouse on the Manager Request tab to display the menu
            Actions actions = new Actions(Driver.driver);
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Manage Requests']"));
            actions.MoveToElement(uiDropdown).Perform();
        }

         //Click on Received Request
        public static void receivedRequestMenu()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[1]/div/a[1]")).Click();

        }

        public static void SentRequestDropDown()
        {
            Wait.WaitToBeClickable(Driver.driver, "Xpath", "/html/body/div[1]/div/section[1]/div/div[2]/a", 2);

            //Hover the mouse on the Manager Request tab to display the menu
            Actions actions = new Actions(Driver.driver);
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Manage Requests']"));
            actions.MoveToElement(uiDropdown).Perform();
        }

            //Click on Sent Request
        public static void sentRequestsMenu()
        {
            Driver.driver.FindElement(By.XPath("//*[text()='Sent Requests']")).Click();
        }

       //Click on profile
       public static void myProfile()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();
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

        //Assert my details have been changed
        public static void earnTarget()
        {
            IWebElement earnTxt = Driver.driver.FindElement(By.XPath("//*[text()='More than $1000 per month']"));
            Assert.IsTrue(earnTxt.Displayed);
        }

        public static void addLanguageBTN()
        {
            //Click Add New button to add new language
            Driver.driver.FindElement(By.XPath("//table[@class='ui fixed table']//tr/th[3]/div")).Click();
        }

        public static void enterLanguage()
        {
            //Add one of my languages
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Chinese");
        }

        public static void selectLevel()
        {
            //Click the drop down menu of level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

            //Select my lanaguage level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[5]")).Click();
            Wait.WaitToBeVisible(Driver.driver, "Xpath", "//select[@class='ui dropdown']/option[5]", 3);
        }

        public static void clickAddtoSaveLanguage()
        {
            //Click add button to save my selection
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();

        }

        public static void assertLanguageAdded()
        {

            IWebElement LanguageText = Driver.driver.FindElement(By.XPath("//td[text()='Chinese']"));
            Assert.IsTrue(LanguageText.Displayed);
        }

        //Click on Skills tab
        public static void clickSkill()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }


        //Click on Add button to add new skill
        public static void newSkill()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }

        public static void SkillDetails()
        {
 
           //Enter you skill
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Web Development");

            //Click on dropdown menu
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Select one of the options
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")).Click();

        }

        //Click on Save button to save the skill
        public static void saveSkill()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }

        //Assert skill has been saved
        public static void assertSkillSaved()
        {
            IWebElement skillTxt = Driver.driver.FindElement(By.XPath("//*[text()='Web Development']"));
            Assert.IsTrue(skillTxt.Displayed);
        }
        
        public static void clickOnEducation()
        {
            //Click on Education tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

        }

        public static void addNewEdu()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();
        }
        public static void enterEducationDetails()
        {
            
            

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

            

        }

        public static void clickandSaveEducation()
        {
            //Click on Add button to add education details
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
        }

        public static void assertEduAdded()
        {

            //Assert Uni name has bee added
            IWebElement UniNameTxt = Driver.driver.FindElement(By.XPath("//*[text()='Auckland University']"));
            Assert.IsTrue(UniNameTxt.Displayed);
        }
 

        //Click on Descripton edit icon
        public static void addDescription()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();
        }


        public static void enterDescriptionDetails()
        {
        //Enter Description
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).Clear();
            Driver.driver.FindElement(By.XPath("//textarea[@name='value']")).SendKeys("Hi, I have a bunch of skills that can be swapped with you.");

        }

        //Click on the Save button to save the description
        public static void saveDescription()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
        }

        //Assert saved description
        public static void AssertDescription()
        {
            IWebElement DescriptionText = Driver.driver.FindElement(By.XPath("//*[text()='Hi, I have a bunch of skills that can be swapped with you.']"));
            Assert.IsTrue(DescriptionText.Displayed);
           
        }

        //Click on Certification tab
        public static void CertTab()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }

        //Click on add new cert button
        public static void addNewCert()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
        }

        //Enter Certification details
        public static void CertDetails()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("ISTQB");
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("ISTQB");

        //Click to select year of Cert from drop down 
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]")).Click();

        }

        //Click on Save button to save Certification
        public static void saveCertBTN()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
        }

        //Assert the new certificate is saved
        public static void AssertCert()
        {
            IWebElement newCert = Driver.driver.FindElement(By.XPath("//*[text()='ISTQB']"));
            Assert.IsTrue(newCert.Displayed);
        }


        //Change the password to a new one
        //Hover the mouse and waiting for the menu to be displayed
        public static void uiDropdownHover()
        {
            Actions actions = new Actions(Driver.driver);
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Sam']"));
            actions.MoveToElement(uiDropdown).Perform();
        }

        //Click on change password
        public static void changePWmenu()
        {
            Driver.driver.FindElement(By.XPath("//*[text()='Change Password']")).Click();
        }


        public static void changePassword()
        {

            //Enter old password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input")).SendKeys("123123");

            //Enter new password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input")).SendKeys("456456");

            //Confirm new password
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input")).SendKeys("456456");
        }

            //Click on save button to save the new password
        public static void savePW()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button")).Click();
        }
           

        //Change the new password back to old password for further login purpose
        public static void reversePW()
        {
            Actions actions = new Actions(Driver.driver);
            IWebElement uiDropdown = Driver.driver.FindElement(By.XPath("//*[text()='Sam']"));
            actions.MoveToElement(uiDropdown).Perform();  
            Thread.Sleep(6000);
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

