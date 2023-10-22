public class ChecklistGoals : Goals {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoals(string name, string description, string points, int amountCompleted, int target, int bonus) : base (name, description, points){
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent() {
        _amountCompleted++;
        if (_amountCompleted == _target) {
            Console.WriteLine(_points, _bonus);
            int result = int.Parse(_points) + _bonus;
            _points = result.ToString();
        }
    }

    public override bool IsComplete() {
        if (_amountCompleted == _target) {
            return true;
        }
        else {
            return false;
        }
    }

    public override string GetDetailsString() {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation() {
        return "${_shortName} - {_description} [{_points}]";
    }
}