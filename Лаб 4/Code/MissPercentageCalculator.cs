



public class MissPercentageCalculator
{
    private readonly PointsCounter _counter;

    public MissPercentageCalculator(PointsCounter counter)
    {
        _counter = counter;
    }

    public double GetMissPercentage()
    {
        if (_counter.TotalPoints == 0)
            return 0;

        return (double)_counter.MissedPoints / _counter.TotalPoints * 100.0;
    }
}