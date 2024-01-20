using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class MaxCounters
    {
        public int[] Run(int N, int[] A)
        {
            int maxValue = 0;
            int minValue = 0;
            int[] counters = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                int operation = A[i];
                if (operation == N + 1)
                {
                    minValue = maxValue;
                }
                else
                {
                    operation--;
                    counters[operation] = Math.Max(counters[operation] + 1, minValue + 1);
                    maxValue = Math.Max(maxValue, counters[operation]);
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], minValue);
            }

            return counters;
        }
    }
}
