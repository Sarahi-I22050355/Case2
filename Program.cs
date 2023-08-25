using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = SumWithLINQ(numbers);
            Console.WriteLine("The sum is: " + sum);
        }

        static int SumWithLINQ(List<int> list)
        {
            return list.Sum();
        }
    }
}
