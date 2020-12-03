using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Rechnertest
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private double x, y;
        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            x = Math.PI;
        }
        
        [When(@"the sinus of number")]
        public void WhenTheSinusOfNumber()
        {
            y = Math.Sin(x);
        }
        
        [When(@"the cosinus of number")]
        public void WhenTheCosinusOfNumber()
        {
            y = Math.Cos(x);
        }
        
        [When(@"the tangens of number")]
        public void WhenTheTangensOfNumber()
        {
            y = Math.Tan(x);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = y;
            Assert.Equal(expected, actual, 5);
        }
    }
}
