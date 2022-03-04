using System;
using Mars_Specflow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Specflow.Pages
{
    public class SearchPage
    {
        //Click on All Categories menu
        public static void allCategoriesMenu()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[1]/b")).Click();
        }


        //Assert search result(by all categories)
        public static void resultByAllCategories()
        {
            IWebElement searchResultAllCategories = Driver.driver.FindElement(By.XPath("//*[text()='Web Designer']"));
            Assert.IsTrue(searchResultAllCategories.Displayed);
        }
        //Click on Graphi&Design Category
        public static void GraphicsDesignCategory()
        {
            Driver.driver.FindElement(By.XPath("//*[text()='Graphics & Design']")).Click();
        }


        //Click on Web&MObile Design Sub-category
        public static void WebMobileDesign()
        {
            Driver.driver.FindElement(By.XPath("//*[text()='Web & Mobile Design']")).Click();
        }

        //Assert search result(by sub-categories)
        public static void searchResult()
        {
            IWebElement searchResultOfCategory = Driver.driver.FindElement(By.XPath("//*[text()='Sam Xu']"));
            Assert.IsTrue(searchResultOfCategory.Displayed);
        }

        //Search by filters (name)
        public static void SearchByName()
        {
            //Enter the name as search condition
            //Driver.driver.FindElement(By.XPath("//*[@id='service - search - section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input")).Clear();
            Driver.driver.FindElement(By.CssSelector("#service-search-section > div.ui.container > div > section > div > div.four.wide.column > div.ui.grid > div.left.floated.thirteen.wide.column > div > div.ui.icon.input.fluid > input")).SendKeys("tawa1");
        }

      
        //Assert serch result(by name)
        public static void searchResultOfName()
        {
            IWebElement searchResultbyName = Driver.driver.FindElement(By.XPath("//*[text()='tawa1 tester']"));
            Assert.IsTrue(searchResultbyName.Displayed);
        }
    }
}
