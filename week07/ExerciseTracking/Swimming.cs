public class Swimming : Activity
{
    private double _laps;
    public Swimming(double measurement, double time, string date) : base(measurement, time, date)
    {
        _laps = measurement;
    }

     public override double GetDistance()
    {
        
        return _distance = _laps * 50 / 1000.0;
    }
    public override double GetPace()
    {
        return _pace = _time / _distance;
    }
    public override double GetSpeed()
    {
        return _speed = _distance / (_time / 60.0);
    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }  
}