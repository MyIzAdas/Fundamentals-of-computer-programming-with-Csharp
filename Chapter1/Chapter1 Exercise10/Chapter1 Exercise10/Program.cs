using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1_Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i<103; i++) {
                if (Math.IEEERemainder(i,2)==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i*-1);
                }
                
            }
        }
    }
}
