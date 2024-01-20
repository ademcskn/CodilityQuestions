using CodilityQuestions.Questions;

namespace CodilityQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BinaryGap
            //BinaryGap binaryGap = new();
            //Console.WriteLine(binaryGap.Run(1041));
            #endregion

            #region CyclicRotation
            //CyclicRotation cyclicRotation = new();
            //foreach (int i in cyclicRotation.Run(new int[] { 3, 8, 9, 7, 6 }, 1))
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region OddOccurrencesInArray
            //OddOccurrencesInArray oddOccurrencesInArray = new();
            //Console.WriteLine(oddOccurrencesInArray.Run(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
            #endregion

            #region FrogJmp
            //FrogJmp frogJmp = new FrogJmp();
            //Console.WriteLine(frogJmp.Run(5, 25, 10));
            #endregion

            #region PermMissingElem
            //PermMissingElem permMissingElem = new();
            //Console.WriteLine(permMissingElem.Run(new int[] { 1, 2, 3, 5, 6, 7, 8 }));
            #endregion

            #region TapeEquilibrium
            //TapeEquilibrium tapeEquilibrium = new();
            //Console.WriteLine(tapeEquilibrium.Run(new int[] { 5, 4, 3, 3, 4, 5 }));
            #endregion

            #region MaxCounters
            MaxCounters maxCounters = new();
            foreach (int i in maxCounters.Run3(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }))
            {
                Console.Write(i + " ");
            }
            #endregion

            Console.Read();
        }
    }
}
