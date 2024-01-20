using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class MaxCounters
    {
        #region 1.Solutiton 
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
        #endregion

        #region 2.Solution 
        public int[] Run2(int N, int[] A)
        {
            int[] counters = new int[N];
            int maxCounter = 0;
            int lastMaxCounter = 0;

            foreach (int operation in A)
            {
                if (operation >= 1 && operation <= N)
                {
                    int index = operation - 1;
                    counters[index] = Math.Max(counters[index], lastMaxCounter) + 1;
                    maxCounter = Math.Max(maxCounter, counters[index]);
                }
                else if (operation > N)
                {
                    lastMaxCounter = maxCounter;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], lastMaxCounter);
            }

            return counters;
        }
        #endregion

        #region  3.Solution 
        public int[] Run3(int N, int[] A)
        {
            int[] counters = new int[N];
            int maxCounter = 0;
            int lastMaxCounter = 0;

            foreach (int operation in A)
            {
                if (operation >= 1 && operation <= N)
                {
                    int index = operation - 1;
                    counters[index] = Math.Max(counters[index], lastMaxCounter) + 1;
                    maxCounter = Math.Max(maxCounter, counters[index]);
                }
                else if (operation > N)
                {
                    lastMaxCounter = maxCounter;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], lastMaxCounter);
            }

            return counters;
        }
        #endregion
    }
}
