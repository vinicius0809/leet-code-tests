using System.Collections.Generic;
using System.Collections.ObjectModel;

public class TechnicalInterview
{
    public long PickGifts(int[] gifts, int k)
    {
        long sum = 0;
        var auxList = new List<long>(gifts.Select(g =>
        {
            sum += g;
            return (long)g;
        }
        ));

        for (int i = 0; i < k; i++)
        {
            long highest = auxList.Max();
            long floorSqrt = Convert.ToInt32(Math.Floor(Math.Sqrt(highest)));
            auxList.Add(floorSqrt);
            auxList.Remove(highest);
            sum += floorSqrt - highest;
        }

        return sum;
    }
}