public class Running : Activity
{
    public Running(double measurement, double time, string date) : base(measurement, time, date)
    {
        _distance = measurement;
    }
     public override double GetDistance()
    {

        return _distance;
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