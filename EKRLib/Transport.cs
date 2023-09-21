namespace EKRLib;

/// <summary>
/// Represents abstract class of transports 
/// </summary>
public abstract class Transport
{
    public Transport(string model, uint power)
    {
        Model = model;
        Power = power;
    }

    private string model;
    private uint power;

    public string Model
    {
        get
        {
            return model;
        }

        set
        {
            // throw exception if length is not 5 or have invalid symbols
            if (value.Length != 5)
            {
                throw new TransportException("Недопустимая модель " + Model);
            }

            foreach (var sym in value)
            {
                if (('A' > sym || sym > 'Z') && ('0' > sym || sym > '9'))
                {
                    throw new TransportException("Недопустимая модель " + Model);
                }
            }
            model = value;
        }
    }

    public uint Power
    {
        get
        {
            return power;
        }

        set
        {
            // Throw excpetion if value less than 20
            if (value < 20)
            {
                throw new TransportException("Мощность не может быть меньше 20 л.с.");
            }
            else
            {
                power = value;
            }
        }
    }

    /// <summary>
    /// A method for getting sound of the transport
    /// </summary>
    /// <returns>A string designating the sound of transport</returns>
    public abstract string StartEngine();

    public override string ToString()
    {
        return $"Model: {Model}, Power: {Power}";
    }
}