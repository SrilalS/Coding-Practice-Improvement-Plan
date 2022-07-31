using System;
using System.Linq;

namespace Distinct_Subsequences
{

    class DistinctSubsequences
    {

        public static int GetSubSequences(string Sequence, string SubSequence)
        {
            int lenSubSeq = SubSequence.Length;
            Char[] SequenceChars = Sequence.ToCharArray();
            var res = SequenceChars.GetCombinations(lenSubSeq);

            int Count = 0;
            foreach (var item in res)
            {
                if (string.Join("", item.ToArray()) == SubSequence)
                {
                    Count++;
                }
            }
            return Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string Sequence = Console.ReadLine();
            Console.WriteLine("Enter the SubString:");
            string SubSequence = Console.ReadLine();


            Console.WriteLine("No. of Distinct Subsequences: " + GetSubSequences(Sequence, SubSequence));
        }
    }
}
