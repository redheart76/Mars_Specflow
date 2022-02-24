using System;
using Mars_Specflow.Helpers;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class NotificationPage
    {
        //Click on Load More
        public void loadMoreNotificaions()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")).Click();
        }

        //Click on Show Less
        public void showLessNotificaitons()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[11]/div[1]/center/a")).Click();
        }

        //Click on the notification check box to select and unselect
        public void checkBox1()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/input")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/input")).Click();

        }

        //Mark selection as read
        public void checkBox2()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[3]/input")).Click();
            Driver.driver.FindElement(By.XPath("//html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[4]/i")).Click();
        }

        //Delete the selected notificaton
        public void checkBox3()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[4]/div/div/div[3]/input")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[3]/i")).Click();
        }
    }
}
