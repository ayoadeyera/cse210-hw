public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No completion logic; bad habits are an ongoing challenge.
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- [Bad Habit]";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}