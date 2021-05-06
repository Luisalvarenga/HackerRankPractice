using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    public class Easy
    {
        public List<int> breakingTheRecords(List<int> scores)
        {
            int counterMax = 0, counterMin = 0, max = scores[0], min = scores[0];
            List<int> results = new List<int>();

            foreach (var item in scores)
            {
                if (item > max)
                {
                    max = item;
                    counterMax++;
                }
                if (item < min)
                {
                    min = item;
                    counterMin++;
                }

            }
            results.Add(counterMax);
            results.Add(counterMin);
            return results;
        }


        public int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int counterSumPairs = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i; j < ar.Count; j++)
                {
                    if (i < j)
                    {
                        if ((ar[i] + ar[j]) % k == 0)
                        {
                            // Console.WriteLine("ar[" + i + "] + ar[" + j + "] = " + ar[i] + " + " + ar[j] + " = " + sum);
                            counterSumPairs++;
                        }
                    }
                }
            }
            return counterSumPairs;
        }


    }
}
