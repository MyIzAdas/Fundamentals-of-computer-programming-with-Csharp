using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number and press \"Enter\"");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num & 4) != 0)
            {
                Console.WriteLine("3rd bit is 1.");
            }
            else
            {
                Console.WriteLine("3rd bit is 0.");
            }
        }
    }
}
