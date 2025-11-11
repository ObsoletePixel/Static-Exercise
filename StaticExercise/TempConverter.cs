namespace StaticExercise;

public static class TempConverter
{
    public static double FToC(double fahrenheit)
    {
        return (fahrenheit - 32) * (5.0 / 9.0);
    }

    public static double CToF(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}