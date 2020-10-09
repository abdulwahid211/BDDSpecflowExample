using TechTalk.SpecFlow;
using System;
using NUnit.Framework;

namespace RunPractise.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Assert.Equals(1, 4);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
         Assert.Pass();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            Assert.Pass();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.Fail();
        }
    }
}
