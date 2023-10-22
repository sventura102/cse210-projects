public class EternalGoals : Goals {
    public EternalGoals(string name, string description, string points) : base (name, description, points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent() {

    }

    public override bool IsComplete() {
        //can never be compeleted
        return false;
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation() {
        return "${_shortName} - {_description} [{_points}]";
    }
}