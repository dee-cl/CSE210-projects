public class Cycling : Activity
{
    
    public Cycling(double measurement, double time, string date) : base(measurement, time, date)
    {
        _speed = measurement;
    }

    public override double GetDistance()
    {
        return _distance = _speed * _time;
    }
    public override double GetPace()
    {
        return _pace = 60 / _speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }  
    
        
    
    
}