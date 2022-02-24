using System;
using Mars_Specflow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class SearchPage
    {

        //Click on Graphi&Design Category
        public void GraphicsDesignCategory()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[1]/div/a[2]/b")).Click();
        }

        //Click on Logo Design Sub-category
        public void LogoDesignSubcategory()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[1]/div/a[3]/b")).Click();
        }


        //Click on Web&MObile Design Sub-category
        public void WebMobileDesign()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[1]/div/a[6]/b")).Click();
        }

        //Assert search result
        public static void searchResult()
        {
            IWebElement searchResultOfCategory = Driver.driver.FindElement(By.XPath("//*[text()='Sam Xu']"));
            Assert.IsTrue(searchResultOfCategory.Displayed);
        }

        //Search by filters (name)
        public void SearchByName()
        {
            //Enter the name as search condition
            Driver.driver.FindElement(By.XPath("//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input")).Clear();
            Driver.driver.FindElement(By.XPath("//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input")).SendKeys("tawa1");
        }

        //Assert serch result(by name)
        public static void searchResultOfName()
        {
            IWebElement searchResultbyName = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div/div/span"));
            Assert.IsTrue(searchResultbyName.Displayed);
        }
    }
}
