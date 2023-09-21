namespace EKRLib;

[Serializable]
public class TransportException : Exception
{
    public TransportException() : base() { }

    public TransportException(string message) : base(message) { }

    public TransportException(string message, Exception innerException) : base(message, innerException) { }

    public TransportException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
