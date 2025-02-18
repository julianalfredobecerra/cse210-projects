using System;
class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    
    public override bool IsComplete() => _amountCompleted >= _target;
    
    public override string GetStringRepresentation()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) - {_amountCompleted}/{_target} completed, {_points} points each, bonus {_bonus}";
    }
}