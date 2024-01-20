using System;
using System.Collections.Generic; 
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class OddOccurrencesInArray
    {
        internal int Run(int[] A)
        {
            #region 1.Solution 
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //foreach (var item in A)
            //{
            //    if (!dictionary.ContainsKey(item))
            //    {
            //        dictionary.Add(item, 1);
            //    }
            //    else
            //    {
            //        dictionary[item]++;
            //    }
            //}
            //var query = dictionary.Where(k => (k.Value == 1)).ToDictionary(k => k.Key, k => k.Value);

            //foreach (var p in query)
            //{
            //    return p.Key;
            //}
            #endregion

            #region 2.Solution
            //var result = A.Aggregate(0, (a, b) => a ^ b);
            #endregion

            #region 3.Solution
            HashSet<int> aList = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int a = A[i];
                if (aList.Contains(a))
                {
                    aList.Remove(a);
                }
                else
                {
                    aList.Add(a);
                }
            }
            return aList.FirstOrDefault();
            #endregion 
        }
    }
}
