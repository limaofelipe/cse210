
public class Running : Activity
{
    private double _runningDistance;

    public Running()
    {}

    private void SetRunningDistance()
    {
        Console.Write("Enter distance ran: ");
        _runningDistance = double.Parse(Console.ReadLine());
    }

    private double GetRunningDistance()
    {
        return _runningDistance;
    }

    public override double CalculateDistance()
    {
        double distance = 0;
        if (GetMetricUnit() == "km")
        {
            distance = GetRunningDistance() * GetExerciseDuration() / 1000;
        } 
        else if (GetMetricUnit() == "miles")
        {
            distance = GetRunningDistance() * GetExerciseDuration() / (1000 * 0.62);
        }
        return distance;
    }

    public override double CalculateSpeed()
    {
        double computeSpeed = (GetRunningDistance() / GetExerciseDuration()) * 60;
        return computeSpeed;
    }

    public override double CalculatePace()
    {
        double computePace = GetExerciseDuration() / GetRunningDistance();
        return computePace;
    }

    public void StartRunning()
    {
        StartExercise();
        SetRunningDistance();
    }
}