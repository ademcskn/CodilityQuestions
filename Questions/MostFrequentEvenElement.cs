using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class MostFrequentEvenElement
    {
        public int FindMostFrequentEvenElement(int[] nums)
        {
            List<int> evenElements = new List<int>();

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    evenElements.Add(num);
                }
            }

            if (evenElements.Count == 0)
            {
                return -1;
            }
            int mostFrequentEvenElement = evenElements.GroupBy(x => x).OrderByDescending(g => g.Count()).ThenBy(e => e.Key).First().Key;

            return mostFrequentEvenElement;
        }
    }
}
