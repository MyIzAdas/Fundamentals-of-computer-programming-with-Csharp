using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight?");
            double weight = Convert.ToDouble(Console.ReadLine());
            double mWeight = weight / 100 * 17;
            Console.WriteLine("Your weight on the moon is: "+mWeight);
        }
    }
}
