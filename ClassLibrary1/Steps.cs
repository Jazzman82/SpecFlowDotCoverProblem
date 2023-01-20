using FluentAssertions;
using TechTalk.SpecFlow;

namespace EndToEndTests
{
  [Binding]
  public class Steps
  {
    private int first = 0;
    private int second = 0;
    private int result = 0;

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int p0)
    {
      result.Should()
            .Be(p0);
    }

    [Given(@"the first number is (.*)")]
    public void GivenTheFirstNumberIs(int p0)
    {
      first = p0;
    }

    [Given(@"the second number is (.*)")]
    public void GivenTheSecondNumberIs(int p0)
    {
      second = p0;
    }

    [When(@"the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
      result = first + second;
    }
  }
}