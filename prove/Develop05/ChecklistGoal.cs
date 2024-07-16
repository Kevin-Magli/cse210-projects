public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points,int bonus, int target, int amountCompleted, bool isCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _isCompleted = isCompleted;
    }

    public int GetTarget() {
        return _target;
    }
    public int GetBonus() {
        return _bonus;
    }

    public int GetAmountCompleted() {
        return _amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _isCompleted = true;
            return _points + _bonus;
        }
        return _points;
    }
    public override bool IsComplete() {

        if (_isCompleted) {
            return true;
        } else {
            return false;
        }
    }
    public override string GetDetailsString() {
        return $"-- Currently completed: {_amountCompleted} / {_target}";
    }
    public override string GetStringRepresentation() {
        return $"ChecklistGoal, {_name},{_description},{_points},{_bonus},{_target},{_amountCompleted},{_isCompleted}";
    }
}