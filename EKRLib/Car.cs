namespace EKRLib;

/// <summary>
/// Represents class inherited from <see cref="Transport"/>
/// </summary>
public class Car : Transport
{
    public Car(string model, uint power) : base(model, power) { }

    public override string ToString()
    {
        return "Car. " + base.ToString();
    }

    public override string StartEngine()
    {
        return $"{Model}: Vroom";
    }
}