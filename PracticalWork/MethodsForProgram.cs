using EKRLib;
using System.Text;

partial class Program
{
    /// <summary>
    /// Returns a random count of transport.
    /// </summary>
    /// <returns>An integer from 6 to 10.</returns>
    private static int GetRandomCountOfTransport()
    {
        Random random = new Random();

        return random.Next(6, 10);
    }

    /// <summary>
    /// Returns a random Power.
    /// </summary>
    /// <returns>An unsigned integer from 10 to 100.</returns>
    private static uint GetRandomPower()
    {
        Random random = new Random();

        return (uint)random.Next(10, 100);
    }

    /// <summary>
    /// Returns a random string for model.
    /// </summary>
    /// <returns>A string of valid characters of length 5.</returns>
    private static string GetRandomModel()
    {
        Random random = new Random();
        string validCharacters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string model = "";

        for (int i = 0; i < 5; i++)
        {
            model += validCharacters[random.Next(0, validCharacters.Length)];
        }

        return model;
    }

    /// <summary>
    /// Creates and returns an object of the <see cref="EKRLib.Car"/> class.
    /// </summary>
    /// <returns>An object of the <see cref="EKRLib.Car"/> class with random model and power.</returns>
    /// <exception cref="TransportException"/>
    private static Car GetCar()
    {
        return new Car(GetRandomModel(), GetRandomPower());
    }

    /// <summary>
    /// Create and return an object of the <see cref="EKRLib.MotorBoat"/> class.
    /// </summary>
    /// <returns>An object of the <see cref="EKRLib.MotorBoat"/> class with random model and power.</returns>
    /// <exception cref="TransportException"/>
    private static MotorBoat GetMotorBoat()
    {
        return new MotorBoat(GetRandomModel(), GetRandomPower());
    }

    /// <summary>
    /// Returns a randomly created object of <see cref="EKRLib.Car"/> or <see cref="EKRLib.MotorBoat"/> class.
    /// </summary>
    /// <returns>An object of <see cref="EKRLib.Car"/> or <see cref="EKRLib.MotorBoat"/> class with random model and power.</returns>
    private static Transport GetTransport()
    {
        Random random = new Random();

        if (random.Next(0, 2) == 0)
        {
            return GetCar();
        }
        else
        {
            return GetMotorBoat();
        }
    }

    /// <summary>
    /// Creates 2 files with <see cref="EKRLib.Car"/> objects and <see cref="EKRLib.MotorBoat"/> objects.
    /// </summary>
    /// <param name="transports"> List with objects of <see cref="EKRLib.Transport"/> class</param>
    private static void SaveInfoAboutTransports(List<Transport> transports)
    {
        List<String> cars = new List<String>();
        List<String> motorboats = new List<String>();

        for (int i = 0; i < transports.Count; i++)
        {
            //Add result of ToString method in arrays
            if (transports[i] is Car)
            {
                cars.Add(transports[i].ToString());
            }
            else
            {
                motorboats.Add(transports[i].ToString());
            }
        }

        //Creates files in UTF-16 
        File.WriteAllLines("../../../../Cars.txt", cars.ToArray(), Encoding.Unicode);
        File.WriteAllLines("../../../../MotorBoats.txt", motorboats.ToArray(), Encoding.Unicode);
    }

    /// <summary>
    /// Depending on the user's input, the program will work or not
    /// </summary>
    /// <returns>A bool, meaning continue program or not</returns>
    private static bool ContinueProgram()
    {
        //Program continues until user inputs "Y" or "N"
        while (true)
        {
            Console.Write("Нажмите 'Y', чтобы запустить программу, или 'N', чтобы выйти: ");

            var userKey = Console.ReadKey().Key;

            if (userKey == ConsoleKey.Y)
            {
                Console.WriteLine();
                return true;
            }
            else if (userKey == ConsoleKey.N)
            {
                return false;
            }
            else
            {
                Console.WriteLine("\nВведен неизвестный символ! Попробуйте еще раз.");
            }
        }
    }
}