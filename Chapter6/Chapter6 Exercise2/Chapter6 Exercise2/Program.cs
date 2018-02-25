using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                if(i%3!=0 && i%7!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
