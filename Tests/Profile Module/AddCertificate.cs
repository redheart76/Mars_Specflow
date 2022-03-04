using System;

using TechTalk.SpecFlow;

namespace Mars_Specflow.Tests
{
    [Binding]
    public class AddCertificate
    {

        private readonly ScenarioContext _scenarioContext;

        public AddCertificate(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have navigated to the certification section")]
        public void GivenIHaveNavigatedToTheCertificationSection()
        {
            Pages.ProfilePage.CertTab();
        }

        [Given(@"I click on Add New cert button")]
        public void GivenIClickOnAddNewCertButton()
        {
            Pages.ProfilePage.addNewCert();
        }

        [Given(@"I have entered my new cetifecate details")]
        public void GivenIHaveEnteredMyNewCetifecateDetails()
        {
            Pages.ProfilePage.CertDetails();
        }

        [When(@"I click on Add button to add a new certificate")]
        public void WhenIClickOnAddButtonToAddANewCertificate()
        {
            Pages.ProfilePage.saveCertBTN();
        }

        [Then(@"the new cetificate will be saved")]
        public void ThenTheNewCetificateWillBeSaved()
        {
            Pages.ProfilePage.AssertCert();
        }
    }
 }
