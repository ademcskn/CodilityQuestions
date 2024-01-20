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
            #region 1.Çözüm
            //string binaryN = Convert.ToString(N, 2);
            //int counter = 0;
            //int maxCount = 0;
            //bool started = false;
            //for (int i = 0; i < binaryN.Length; i++)
            //{
            //    string subS = binaryN.Substring(i, 1);
            //    if (subS == "1")
            //    {
            //        if (started)
            //        {
            //            if (counter > maxCount)
            //            {
            //                maxCount = counter;
            //            }
            //        }
            //        started = true;
            //        counter = 0;
            //    }
            //    else if (subS == "0")
            //    {
            //        if (started)
            //        {
            //            counter++;
            //        }
            //    }
            //}
            //return maxCount;
            #endregion

            #region 2.Çözüm
            int value = 0;
            var results = new List<int>();
            var binaryN = Convert.ToString(N, 2);
            foreach (var bin in binaryN)
            {
                if (bin.Equals('0'))
                    value += 1;
                else
                {
                    results.Add(value);
                    value = 0;
                }
            }
            return results.Max();
            #endregion
        }
    }
}
