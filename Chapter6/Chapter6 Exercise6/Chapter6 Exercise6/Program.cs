using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter N and K values for N!/K! calculation.");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int nFact = 1;
            Console.Write("K: ");
            int k = int.Parse(Console.ReadLine());
            int kFact = 1;
            for(int i=1;i<=n;i++)
            {
                nFact = nFact * i;
            }
            if (1 < k && k < n)
            {
                for (int a = 1; a <= k; a++)
                {
                    kFact = kFact * a;
                }
                Console.WriteLine("N!/K!= " + (nFact / kFact));
            }
            else
            {
                Console.WriteLine("K must be 1<K<N!");
            }
        }
    }
}
