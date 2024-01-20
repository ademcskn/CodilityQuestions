using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class TapeEquilibrium
    {
        public int Run(int[] A)
        {
            int minDiff = int.MaxValue;
            int numbersOnRight = 0;
            int numbersOnLeft = 0;
            for (int i = 0; i < A.Length; i++)
            {
                numbersOnRight += A[i];
            }

            for (int i = 0; i < A.Length - 1; i++)
            {
                numbersOnRight -= A[i];
                numbersOnLeft += A[i];
                if (Math.Abs(numbersOnLeft - numbersOnRight) < minDiff)
                {
                    minDiff = Math.Abs(numbersOnLeft - numbersOnRight);
                }
            }
            return minDiff;
        }
    }
}
