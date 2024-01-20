using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class PermMissingElem
    {
        public int Run(int[] A)
        {
            HashSet<int> B = new HashSet<int>();
            for (int i = 1; i <= A.Length + 1; i++)
            {
                B.Add(i);
            }
            for (int i = 0; i < A.Length; i++)
            {
                B.Remove(A[i]);
            }

            return B.FirstOrDefault();
        }
    }
}
