using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class CyclicRotation
    {
        internal int[] Run(int[] A, int K)
        {
            if (K == A.Length || K == 0)
            {
                return A;
            }
            else
            {
                for (int i = 0; i < K; i++)
                {
                    int lastValue = A[A.Length - 1];
                    for (int j = A.Length - 2; j >= 0; j--)
                    {
                        A[j + 1] = A[j];
                    }
                    A[0] = lastValue;
                }
            }
            return A;
        }
    }
}
