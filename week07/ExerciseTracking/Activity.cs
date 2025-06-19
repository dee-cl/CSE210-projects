using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

public abstract class Activity
{
    protected double _measurement;
    protected string _date;
    protected double _time;
    protected double _distance;
    protected double _speed;
    protected double _pace;

    public Activity(double measurement, double time, string date)
    {
        _measurement = measurement;
        _date = date;
        _time = time;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per k
        return $"{_date} {GetType().Name} ({_time} Minutes): Distance  {GetDistance()} km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km";
    }


}