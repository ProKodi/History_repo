



using System.Diagnostics.Tracing;

[EventSource(Name = "Lab3.PointsMetrics")]
public sealed class PointsMetricsEventSource : EventSource
{
    public static readonly PointsMetricsEventSource Log =
        new PointsMetricsEventSource();

    private int _totalPoints;
    private int _missedPoints;

    private PollingCounter _totalPointsCounter;
    private PollingCounter _missedPointsCounter;
    private PollingCounter _missPercentageCounter;

    private PointsMetricsEventSource()
    {
        _totalPointsCounter = new PollingCounter(
            "total-points",
            this,
            () => _totalPoints)
        {
            DisplayName = "Total Points"
        };

        _missedPointsCounter = new PollingCounter(
            "missed-points",
            this,
            () => _missedPoints)
        {
            DisplayName = "Missed Points"
        };

        _missPercentageCounter = new PollingCounter(
            "miss-percentage",
            this,
            () =>
                _totalPoints == 0
                    ? 0
                    : (double)_missedPoints / _totalPoints * 100)
        {
            DisplayName = "Miss Percentage"
        };
    }

    public void Update(int total, int missed)
    {
        _totalPoints = total;
        _missedPoints = missed;
    }
}