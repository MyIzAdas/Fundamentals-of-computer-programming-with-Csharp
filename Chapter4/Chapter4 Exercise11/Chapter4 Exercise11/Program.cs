using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = 0;
            ulong x = 1;
            for(int i=0;i<100;i++)
            {
                n = n + x;
                x = x + n;                
                Console.Write(n+" "+x+" ");
            }
        }
    }
}
