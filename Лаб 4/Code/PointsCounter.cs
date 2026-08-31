



public class PointsCounter
{
    public int TotalPoints { get; private set; }
    public int MissedPoints { get; private set; }

    public event EventHandler<int>? PointsMultipleOfTenReached;

    public void AddPoint(bool isHit)
    {
        TotalPoints++;

        if (!isHit)
            MissedPoints++;

        // обновляем "MBean"
        PointsMetricsEventSource.Log.Update(
            TotalPoints,
            MissedPoints
        );

        if (TotalPoints % 10 == 0)
            PointsMultipleOfTenReached?.Invoke(this, TotalPoints);
    }
}