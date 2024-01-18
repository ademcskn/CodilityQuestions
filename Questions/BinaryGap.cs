using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class BinaryGap
    {
        internal int Run(int N) 
        {
            bool started = false;
            int counter = 0;
            int maxCount = 0;
            string binaryN = Convert.ToString(N, 2);
            for (int i = 0; i < binaryN.Length; i++)
            {
                string subS = binaryN.Substring(i, 1);
                if (subS == "1")
                {
                    if (started)
                    {
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                        }
                    }
                    counter = 0;
                    started = true;
                }
                if (subS == "0")
                {
                    counter++;
                }
            }
            return maxCount;
        }
    }
}
