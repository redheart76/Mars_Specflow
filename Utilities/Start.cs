using Mars_Specflow.Helpers;
using Mars_Specflow.Pages;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;
using static Mars_Specflow.Helpers.CommonMethods;

namespace Mars_Specflow.Utilities
{
    [Binding]
    public class Start : Driver
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentReports();
        }

        //[BeforeFeature]
        //public static void BeforeFeature(FeatureContext context)
        //{
        //    test = Extent.Config(context.FeatureInfo.Title);
        //}

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            //ExcelLibHelper.PopulateInCollection(@"/Users/sam/Mars_Specflow/Data/Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.Login();
        }

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            Close();

            // end test. (Reports)
            //CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();


        }
    }
}
