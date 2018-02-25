using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'n'-number and 'p'-bit position and I will show you what bit is on that number in that position.");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int bit = 1;
            int position = bit << p;
            Console.WriteLine((n&position) ==0 ? 0 : 1);
        }
    }
}
