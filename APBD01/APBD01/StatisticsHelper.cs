namespace APBD01;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        double sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        return sum / values.Length;
    }
}