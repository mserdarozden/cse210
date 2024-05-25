public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()

    {
        string completionString = "";
        if (IsComplete())
        {
            completionString = "[X]";
        }
        else 
        {
            completionString = "[ ]";
        }

        return completionString + " " + _shortName + " " + "(" + _description + ")";
    }

    public abstract string GetStringRepresentation();
    public virtual int getPoints()
    {
        return int.Parse(_points);
    }

    public string getGoalName()
    {
        return _shortName;
    }   
}