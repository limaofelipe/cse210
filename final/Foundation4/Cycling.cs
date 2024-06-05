

public class Cycling : Activity
{
    private int _clyclingSpeed;

    public Cycling()
    {}

    private void SetCyclingSpeed()
    {
        Console.Write("Enter cycling speed: ");
        _clyclingSpeed = int.Parse(Console.ReadLine());
    }

    private int GetCyclingSpeed()
    {
        return _clyclingSpeed;
    }

    public override double CalculateDistance()
    {
        double distance = 0;
        if (GetMetricUnit() == "km")
        {
            distance = GetCyclingSpeed() * GetExerciseDuration() / 1000;
        } 
        else if (GetMetricUnit() == "miles")
        {
            distance = GetCyclingSpeed() * GetExerciseDuration() / (1000 * 0.62);
        }
        return distance;
    }

    public override double CalculateSpeed()
    {
        double computeSpeed = (GetCyclingSpeed() / GetExerciseDuration());
        return computeSpeed;
    }

    public override double CalculatePace()
    {
        double computePace = GetExerciseDuration() / GetCyclingSpeed();
        return computePace;
    }

    public void StartCycling()
    {
        StartExercise();
        SetCyclingSpeed();
    }
}