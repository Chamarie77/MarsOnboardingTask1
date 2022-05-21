using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class SellerAddProfileDetailsStepDefinitions
    {
        [Given(@"I logged into localhost:(.*)/Home successfully")]
        public void GivenILoggedIntoLocalhostHomeSuccessfully(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Profile Page")]
        public void WhenINavigateToProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new profile")]
        public void WhenICreateANewProfile()
        {
            throw new PendingStepException();
        }

        [Then(@"Then the file should be created successfully")]
        public void ThenThenTheFileShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing Profile File")]
        public void WhenIUpdateAndOnAnExistingProfileFile(string sinhalese, string specFlow, string java)
        {
            throw new PendingStepException();
        }

        [Then(@"the Profile file s hould have the updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheProfileFileSHouldHaveTheUpdatedAnd(string sinhalese, string specFlow, string java)
        {
            throw new PendingStepException();
        }

    }
}
