using EKRLib;

partial class Program
{
    private static void Main()
    {

        while (ContinueProgram())
        {
            List<Transport> ListOfTransports = new List<Transport>();

            // Add random count of transports
            for (int i = 0; i < GetRandomCountOfTransport(); i++)
            {
                bool isWork = true;

                // Trying to create an object, if excluded, try again
                do
                {
                    try
                    {
                        ListOfTransports.Add(GetTransport());
                        Console.WriteLine(ListOfTransports[i].StartEngine());
                        isWork = true;
                    }
                    catch (TransportException ex)
                    {
                        Console.WriteLine(ex.Message);
                        isWork = false;
                    }
                }
                while (isWork == false);
            }

            // Saves information about transports
            try
            {
                SaveInfoAboutTransports(ListOfTransports);
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown Error! Files don't create.");
            }

        }
    }
}