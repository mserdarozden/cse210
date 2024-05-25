public class ChecklistGoal: Goal
{
    private int _amountComplate;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountComplate = 0;
    }
    public override void RecordEvent()
    {
        _amountComplate++;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You earned {int.Parse(_points)+_bonus} points!");
        }
        else 
        {
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }

    }

    public override bool IsComplete()
    {
        if (_amountComplate >= _target)
        {
            return true;
        } 
        else 
        {
            return false;
        }
        
    }

    public override string GetDetailsString()

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

        return completionString + " " + _shortName + " " + "(" + _description + ")" + " -- Currently complated: " + _amountComplate + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountComplate}";
    }

    public override int getPoints()
    {
        if (IsComplete())
        {
            return int.Parse(_points) + _bonus;
        }
        else 
        {
            return int.Parse(_points);
        }
    }
    public void SetAmountComplete(int amountComplete)
    {
        _amountComplate = amountComplete;
    }
}