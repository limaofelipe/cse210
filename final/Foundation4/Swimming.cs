
public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming()
    {}

    private void SetSwimmingLaps()
    {
        Console.Write("Enter swimming laps: ");
        _numberOfLaps = int.Parse(Console.ReadLine());
    }

    private int GetSwimmingLaps()
    {
        return _numberOfLaps;
    }

    public override double CalculateDistance()
    {
        double distance = 0;
        if (GetMetricUnit() == "km")
        {
            distance = GetSwimmingLaps() * GetExerciseDuration() / 1000;
        } 
        else if (GetMetricUnit() == "miles")
        {
            distance = GetSwimmingLaps() * GetExerciseDuration() / (1000 * 0.62);
        }
        return distance;
    }

    public override double CalculateSpeed()
    {
        double computeLaps = GetSwimmingLaps() / GetExerciseDuration();
        return computeLaps;
    }

    public override double CalculatePace()
    {
        double computePace = GetExerciseDuration() / GetSwimmingLaps();
        return computePace;
    }

    public void StartSwimming()
    {
        StartExercise();
        SetSwimmingLaps();
    }
}