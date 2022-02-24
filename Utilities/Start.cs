using Mars_Specflow.Helpers;
using Mars_Specflow.Pages;
using TechTalk.SpecFlow;
using static Mars_Specflow.Helpers.CommonMethods;

namespace Mars_Specflow.Utilities
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            //ExcelLibHelper.PopulateInCollection(@"/Users/sam/Desktop/Industry Connect/Internship/Project/onboarding.specflow-master/MarsQA-1/SpecflowTests/Data", "Credentials");
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
