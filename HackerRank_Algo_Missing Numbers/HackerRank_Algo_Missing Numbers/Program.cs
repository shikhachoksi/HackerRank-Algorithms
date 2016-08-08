using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Algo_Missing_Numbers
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            string inputA = Console.ReadLine();
            List<int> A = inputA.Split(' ').ToList().ConvertAll(c => Convert.ToInt32(c));
            List<int> sortA = A;
            sortA.Sort();
            int m = Convert.ToInt32(Console.ReadLine());
            string inputB = Console.ReadLine();
            List<int> B = inputB.Split(' ').ToList().ConvertAll(c => Convert.ToInt32(c));
            List<int> sortB = B;
            sortB.Sort();
            List<numberList> OPList = new List<numberList>();
            foreach (var num in sortB.Distinct())
            {
                numberList current = new numberList();
                current.number = num;
                current.frequencyA = sortA.Where(x => x == num).Count();
                current.frequencyB = sortB.Where(x => x == num).Count();
                OPList.Add(current);
            }
            foreach (var item in OPList)
            {
                Console.WriteLine("Number: " + item.number + " A:" + item.frequencyA + " B:" + item.frequencyB);
            }
        }
    }
    class numberList
    {
        public int number { get; set; }
        public int frequencyA { get; set; }
        public int frequencyB { get; set; }
    }
}
