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

        public static List<string> AllNamesWith4OrMoreLetters()
        {
            return names
                .Where(x => x.Count < 4)
        }
    }
}
