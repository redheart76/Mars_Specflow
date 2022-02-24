using System;
using Mars_Specflow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class ReceivedRequestPage
    {
       public static void assertReceivedRequest()
        {
            IWebElement sender = Driver.driver.FindElement(By.XPath("//*[text()='Tawa1']"));
            Assert.IsTrue(sender.Displayed);
        }
    }
}
