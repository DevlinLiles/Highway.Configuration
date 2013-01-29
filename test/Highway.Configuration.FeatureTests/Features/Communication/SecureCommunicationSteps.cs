using System;
using TechTalk.SpecFlow;

namespace Highway.Configuration.FeatureTests
{
    [Binding]
    public class SecureCommunicationSteps
    {
        [Given(@"I have a configuration store")]
        public void GivenIHaveAConfigurationStore()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have settings with sensitive data")]
        public void GivenIHaveSettingsWithSensitiveData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I get the application settings")]
        public void WhenIGetTheApplicationSettings()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the results should be encrypted by a configureable key and a common salt")]
        public void ThenTheResultsShouldBeEncryptedByAConfigureableKeyAndACommonSalt()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
