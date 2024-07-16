public class EternalGoal : Goal 
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent() {

        _isCompleted = false;
        return _points;
    }
    public override bool IsComplete() {

        return false;
    }
    public override string GetStringRepresentation() {
        return $"EternalGoal, {_name},{_description},{_points}";
    }
}