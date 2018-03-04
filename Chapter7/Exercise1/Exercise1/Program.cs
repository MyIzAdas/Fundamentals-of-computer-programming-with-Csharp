using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for(int i=0;i<20;i++)
            {
                array[i] = i*5;
                Console.WriteLine(array[i]);
            }

        }
    }
}
