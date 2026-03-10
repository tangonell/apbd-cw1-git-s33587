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

    public static int CalculateMax(int[] values)
    {
        int max = 0;
        foreach (var value in values)
        {
            if (max < value) max = value;
        }
        return max;
    }
}