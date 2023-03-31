namespace Stats_Percentile;

public class StatsPercentile
{
    private static void Swap<T>(IList<T> data, int i, int j)
    {
        if (i == j) return;
        (data[j], data[i]) = (data[i], data[j]);
    }

    private static int Partition<T>(IList<T> data, int start, int end) where T : IComparable<T>
    {
        int i, j;
        for (i = start + 1, j = start; i < end; i++)
            if (data[i].CompareTo(data[start]) < 0)
                Swap(data, i, ++j);
        Swap(data, start, j);
        return j;
    }

    private static T FindK<T>(IList<T> data, int start, int end, int k) where T : IComparable<T>
    {
        while (start < end)
        {
            var pos = Partition(data, start, end);
            if (pos == k) return data[k];
            if (pos > k)
                end = pos;
            else
                start = pos + 1;
        }

        throw new ArgumentException("k is out of range");
    }
 
    public static T Percentile<T>(IList<T> data, double n) where T : IComparable<T>
    {
        return FindK(data.ToList(), 0, data.Count, (int)Math.Ceiling(data.Count * n / 100) - 1);
    }
}