namespace FlightSearch.Core;

public class FlightSearch
{
    private FlightResult _flightResult { get; set; }
    private FlightQuery _flightQuery { get; set; }

    public FlightSearch()
    {
        _flightResult = new FlightResult()
        {
            FlightData = new List<FlightData>()
            {
                new()
                {
                    From = "IST",
                    To = "ESB"
                },
                new()
                {
                    From = "IST",
                    To = "AMS"
                },
                new()
                {
                    From = "ESB",
                    To = "CGD"
                }
            }
        };
    }

    public void CreateFlightQuery(FlightQuery flightQuery)
    {
        _flightQuery = flightQuery;
    }

    public string GetFlightResult()
    {
        var flightData = _flightResult.FlightData.Any(x => x.From == _flightQuery.From && x.To == _flightQuery.To);

        if (!flightData) return $"{_flightQuery.From}-{_flightQuery.To} not found";

        return $"{_flightQuery.From}-{_flightQuery.To} found";
    }
}