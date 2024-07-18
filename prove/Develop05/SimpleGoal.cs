public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted) { }

    public override int RecordEvent() {

        if (!_isCompleted) {
            _isCompleted = true;
            return _points;
        } else {
            return 0;
        }
    }
    public override bool IsComplete() {

        if (_isCompleted) {
            return true;
        } else {
            return false;
        }
    }
    public override string GetStringRepresentation() {
        return $"SimpleGoal, {GetName()},{GetDescription()},{_points},{IsComplete()}";
    }
}