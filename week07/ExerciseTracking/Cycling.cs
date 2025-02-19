using System;
class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * (Duration / 60);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return Duration / distance;
    }
}