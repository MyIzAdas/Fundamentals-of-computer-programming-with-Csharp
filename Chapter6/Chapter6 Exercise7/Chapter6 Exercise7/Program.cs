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
            Console.WriteLine("Please Enter N and K values for N!*K!/(N-K)! calculation.");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int nFact = 1;
            Console.Write("K: ");
            int k = int.Parse(Console.ReadLine());
            int kFact = 1;
            int nkFact = 1;
            for (int i = 1; i <= n; i++)
            {
                nFact = nFact * i;
            }
            if (1 < k && k < n)
            {
                for (int a = 1; a <= k; a++)
                {
                    kFact = kFact * a;
                }
                for(int b=1; b<=n-k;b++)
                {
                    nkFact = nkFact * b;
                }
                Console.WriteLine("N!*K!/(N-K)!= " + ((nFact*kFact)/ nkFact));
            }
            else
            {
                Console.WriteLine("K must be 1<K<N.");
            }
        }
    }
}
