class SimpleGoals : Goals {
    public bool _isComplete; 

    public SimpleGoals(string name, string description, string points) : base (name, description, points) {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        if (_isComplete == true) 
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override void RecordEvent() {

    }

    public override string GetStringRepresentation() {
        return "${_shortName} - {_description} [{_points}]";
    }
} 