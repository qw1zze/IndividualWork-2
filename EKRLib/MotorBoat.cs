namespace EKRLib;

/// <summary>
/// Represents class inherited from <see cref="Transport"/>
/// </summary>
public class MotorBoat : Transport
{
    public MotorBoat(string model, uint power) : base(model, power) { }

    public override string ToString()
    {
        return "MotorBoat. " + base.ToString();
    }

    public override string StartEngine()
    {
        return $"{Model}: Brrrbrr";
    }
}
