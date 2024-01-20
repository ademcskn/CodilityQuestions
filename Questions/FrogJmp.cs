using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuestions.Questions
{
    internal class FrogJmp
    {
        public int Run(int X, int Y, int D)
        {
            #region 1.Solution 
            //int pace = 0;
            //if (Y > X)
            //{
            //    while (Y > X)
            //    {
            //        X += D;
            //        pace++;
            //    }
            //    return pace;
            //}
            //return 0;
            #endregion

            #region 2.Solution
            double distance = Convert.ToDouble(Y - X) / Convert.ToDouble(D);
            return Convert.ToInt32(Math.Ceiling(distance));
            #endregion
        }
    }
}
