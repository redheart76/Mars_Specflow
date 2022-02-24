using System;
using Mars_Specflow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class SentRequestPage
    {
        public static void assertSentRequest()
        {
            IWebElement recipient = Driver.driver.FindElement(By.XPath("//*[text()='Tawa1']"));
            Assert.IsTrue(recipient.Displayed);
        }



    }
}
