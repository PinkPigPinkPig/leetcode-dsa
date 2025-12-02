using System.Collections.Generic;
using System.Linq;

namespace CsharpDSA.Exercises.Medium._3623;

public class CountTrapezoids
{
    private int[][] points;
    public CountTrapezoids(int[][] points = null)
    {
        this.points = points ?? new int[][]
        {
            new int[] { 1, 0 },
            new int[] { 2, 0 },
            new int[] { 3, 0 },
            new int[] { 2, 2 },
            new int[] { 3, 2 }
        };
    }

    public int Run()
    {
        Dictionary<int, int> pointNum = new Dictionary<int, int>();
        const int mod = 1000000007;
        long ans = 0, sum = 0;

        foreach (int[] point in this.points) {
            int y = point[1];
            if (pointNum.ContainsKey(y)) {
                pointNum[y]++;
            } else {
                pointNum[y] = 1;
            }
        }

        foreach (int pNum in pointNum.Values) {
            long edge = (long)pNum * (pNum - 1) / 2;
            ans = (ans + edge * sum) % mod;
            sum = (sum + edge) % mod;
        }

        return (int)ans;
    }
}