using FlightSearch.Core;
using FluentAssertions;

namespace FlightExample.Steps;

[Binding]
public class FlightSearchStepDefinitions
{
    private FlightSearch.Core.FlightSearch _flightSearch { get; set; } = new FlightSearch.Core.FlightSearch();
    private FlightQuery _flightQuery { get; set; } = new FlightQuery();

    [Given(@"define the first city as ""(.*)""")]
    public void GivenDefineTheFirstCityAs(string from)
    {
        _flightQuery.From = from;
    }

    [Given(@"define the second city as ""(.*)""")]
    public void GivenDefineTheSecondCityAs(string to)
    {
        _flightQuery.To = to;
    }

    [When(@"two city codes are defined")]
    public void WhenTwoCityCodesAreDefined()
    {
        _flightSearch.CreateFlightQuery(_flightQuery);
    }

    [Then(@"the result should be ""(.*)""")]
    public void ThenTheResultShouldBe(string result)
    {
        var flightResult = _flightSearch.GetFlightResult();
        flightResult.Should().Be(result);
    }
}