using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum=0;
            string input;
            int num;
            bool parseSuccess;
            Console.WriteLine("Give me 5 int numbers.");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("num"+i+": ");
                input = Console.ReadLine();
                parseSuccess = int.TryParse(input, out num);
                while (parseSuccess == false)
                {
                    Console.WriteLine("Please enter int value!");
                    Console.Write("num"+i+": ");
                    input = Console.ReadLine();
                    parseSuccess = int.TryParse(input, out num);
                }
                sum = sum + num;
            }
            Console.WriteLine(sum);
       
        }
    }
}
