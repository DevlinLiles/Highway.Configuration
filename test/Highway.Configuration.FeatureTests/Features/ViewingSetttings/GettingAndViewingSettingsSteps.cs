using System;
using TechTalk.SpecFlow;

namespace Highway.Configuration.FeatureTests
{
    [Binding]
    public class GettingAndViewingSettingsSteps
    {
        [Given(@"I have a windows account that is allowed to view settings")]
        public void GivenIHaveAWindowsAccountThatIsAllowedToViewSettings()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an application in the system with settings")]
        public void GivenIHaveAnApplicationInTheSystemWithSettings()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a windows account that is allowed to edit settings")]
        public void GivenIHaveAWindowsAccountThatIsAllowedToEditSettings()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a windows account that is not allowed to edit settings but is allowed to view them")]
        public void GivenIHaveAWindowsAccountThatIsNotAllowedToEditSettingsButIsAllowedToViewThem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a windows account that is only allowed to view settings from QA and Development")]
        public void GivenIHaveAWindowsAccountThatIsOnlyAllowedToViewSettingsFromQAAndDevelopment()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a windows account that is only allowed view settings from Production")]
        public void GivenIHaveAWindowsAccountThatIsOnlyAllowedViewSettingsFromProduction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a windows account that is allowed to view settings for multiple applications")]
        public void GivenIHaveAWindowsAccountThatIsAllowedToViewSettingsForMultipleApplications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I go to the settings site")]
        public void WhenIGoToTheSettingsSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I view that applications settings")]
        public void WhenIViewThatApplicationsSettings()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I submit an edit for a setting")]
        public void WhenISubmitAnEditForASetting()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the applications in the system I have view permissions on")]
        public void ThenISeeTheApplicationsInTheSystemIHaveViewPermissionsOn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the settings for that application based on environment")]
        public void ThenISeeTheSettingsForThatApplicationBasedOnEnvironment()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the settings are updated")]
        public void ThenISeeTheSettingsAreUpdated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the new settings in the index view")]
        public void ThenISeeTheNewSettingsInTheIndexView()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see the index screen with a message indicating that the edit is not allowed\.")]
        public void ThenISeeTheIndexScreenWithAMessageIndicatingThatTheEditIsNotAllowed_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see settings in the system for my applications")]
        public void ThenISeeSettingsInTheSystemForMyApplications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I do not see settings other than Dev and QA")]
        public void ThenIDoNotSeeSettingsOtherThanDevAndQA()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see settings in the system from my applications")]
        public void ThenISeeSettingsInTheSystemFromMyApplications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I do not see settings other than production")]
        public void ThenIDoNotSeeSettingsOtherThanProduction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see all applications in the system I have view permissions on")]
        public void ThenISeeAllApplicationsInTheSystemIHaveViewPermissionsOn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
