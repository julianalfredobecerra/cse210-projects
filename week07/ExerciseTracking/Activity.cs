using System;
abstract class Activity
{
    private DateTime _date;
    private double _duration;
    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }
    public DateTime Date {get {return _date;}}
    public double Duration {get {return _duration;}}
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        string dateString = _date.ToString("dd MMM yyyy");
        string activityType = this.GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"{dateString} {activityType} ({_duration} min) - Distance {distance:0.0} miles, Speed {speed:0.0} mph, Pace: {pace:0.0} min per mile";
    }
}