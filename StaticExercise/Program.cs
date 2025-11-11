namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cTemp = 32.7;
            var fTemp = 88.4;
            Console.WriteLine($"{cTemp} degrees Celsius is {TempConverter.CToF(cTemp)} in Fahrenheit.");
            Console.WriteLine($"{fTemp} degrees Fahrenheit is {TempConverter.FToC(fTemp)} in Celsius.");
        }
    }
}
