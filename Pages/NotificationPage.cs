using System;
using Mars_Specflow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class NotificationPage
    {
        //Click on Load More
        public static void loadMoreNotificaions()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")).Click();
        }

        //Click on Show Less
        public static void showLessNotificaitons()
        {
            Driver.driver.FindElement(By.XPath("//*[text()='...Show Less']")).Click();

        }

        //Click on the notification check box to select and unselect
        public static void checkBox1()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[5]/div/div/div[3]/input")).Click();
            //Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/input")).Click();

        }

        //Assert the check box is selected
        public static void checkbox1Selected()
        {
            
            IWebElement Checkbox1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[5]/div/div/div[3]/input"));
            Assert.IsTrue(Checkbox1.Selected);
        }



        //Click to select and unselect the check box of a selected notification
        public static void checkBox2()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[3]/input")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[3]/input")).Click();

        }

        //Assert the check box is unselected
        public static void checkbox2UnSelected()
        {

            IWebElement Checkbox2 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[3]/input"));
            Assert.IsFalse(Checkbox2.Selected);
        }

        //Select a notification
        public static void checkBox3()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[3]/input")).Click();
        }

        //Delete the selected notification
        public static void notificationDeletion()
        {
            
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[3]/i")).Click();
        }

        public static void assertLoadedNotification()
        {
            IWebElement sender = Driver.driver.FindElement(By.XPath("//*[text()='Updated at 14:36 on 7 February 2022']"));
            Assert.IsTrue(sender.Displayed);
        }

        public static bool IsElementPresent()
        {
            try
            {
                Driver.driver.FindElement(By.XPath("//*[text()='Updated at 14:36 on 7 February 2022']"));
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
