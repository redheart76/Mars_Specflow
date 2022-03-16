using System;
using Mars_Specflow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class MessagePage
    {

        //Click on the person who is chatting with
        public static void personChattingWith()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[2]/div[1]")).Click();
        }

        //Assert Chat history
        public static void chatHistory()
        {
            IWebElement chatTxt = Driver.driver.FindElement(By.XPath("//*[text()='It was good. Thanks. What about you?']"));
            Assert.IsTrue(chatTxt.Displayed);
        }
    }
}
