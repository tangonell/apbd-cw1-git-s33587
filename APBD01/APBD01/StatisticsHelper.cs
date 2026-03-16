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
        var average = sum / values.Length;
        return average;
    }

    public static int CalculateMax(int[] values)
    {
        if (values.Length == 0) return 0;
        var max = values[0];
        for (var i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
                max = values[i];
        }
        return max;
    }

    public static int CalculateMin(int[] values)
    {
        if (values.Length == 0) return 0;
        var min = values[0];
        for (var i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
                min = values[i];
        }
        return min;
    }
}