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
            string binaryN = Convert.ToString(N, 2);
            int counter = 0;
            int maxCount = 0;
            bool started = false;
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
                    started = true;
                    counter = 0;
                }
                else if (subS == "0")
                {
                    if (started)
                    {
                        counter++;
                    }
                }
            }
            return maxCount;
        }
    }
}
