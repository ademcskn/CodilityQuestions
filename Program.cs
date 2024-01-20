using CodilityQuestions.Questions;

namespace CodilityQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BinaryGap
            //BinaryGap binaryGap = new BinaryGap();
            //Console.WriteLine(binaryGap.Run(1071));
            #endregion

            #region CyclicRotation
            //CyclicRotation cyclicRotation = new CyclicRotation();
            //foreach (int i in cyclicRotation.Run(new int[] { 3, 8, 9, 7, 6 }, 1))
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region OddOccurrencesInArray
            //OddOccurrencesInArray oddOccurrencesInArray = new OddOccurrencesInArray();
            //Console.WriteLine(oddOccurrencesInArray.Run(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
            #endregion

            #region FrogJmp
            FrogJmp frogJmp = new FrogJmp();
            Console.WriteLine(frogJmp.Run(5, 25, 10));
            #endregion

            Console.Read();
        }
    }
}
