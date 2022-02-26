using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Text;
namespace Mars_Specflow.Helpers
{
    public class CommonMethods
    {

        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {

            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;



        public static void ExtentReports()
        {
            Extent = new ExtentReports();
            //extent.Config(ConstantHelpers.ReportXMLPath);

        }
    }
    #endregion
}
