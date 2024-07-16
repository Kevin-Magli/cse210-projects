public abstract class Goal {
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    // constructors (name,description,points)
    public Goal(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
    }
    public Goal(string name, string description, int points, bool isCompleted) {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public string GetName() {
        return _name;
    }
    public string GetDescription() {
        return _description;
    }
    public int GetPoints() {
        return _points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString() {
        return "details";

    }
    public virtual string GetStringRepresentation() {
        return "string representation";
    }
}