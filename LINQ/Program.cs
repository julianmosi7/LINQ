using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        public static string[] names = { "Franz", "Udo", "Hans", "Susi", "Tom", "CSI", "Anton" };
        public static string[] fullNames = { "Franz Müller", "Udo Lehner", "Hans Huber", "Susi Humer", "Tom Kiesl" };
        public static List<int> numbers = new List<int>() { 5, 12, 3 };
        static void Main(string[] args)
        {
            
        }

        public static string[] AllNamesWith4OrMoreLetters()
        {
            return names
                .Where(x => x.Length < 4)
                .ToArray();
        }

        public static string[] AllNamesContainingA()
        {
            string[] n = names
                .Where(x => x.Contains("a"))                
                .ToArray();
            foreach (var item in n)
            {
                item.ToUpper();
            }
            return n;
        }

        public static string[] AllNamesHavingMoreThan3Letters()
        {
            return names
                .Where(x => (x.Length > 3) && ((x.ElementAt(x.Length) == 'i') || (x.ElementAt(x.Length) == 'I')))
                .ToArray();
        }

        public static string[] SplitNamesInFirstAndLastName()
        {
            string[][] n = names
                .Select(x => x.Split(" "))
                .ToArray();
            for (int i = 0; i < n.Length; i++)
            {
                n[i][0].ToUpper();
            }
            return n;
        }
    }
}
