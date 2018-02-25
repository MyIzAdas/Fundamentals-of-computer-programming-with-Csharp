using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be listed from 1 to n.");
            Console.Write("n ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int i;
            int[] numbers= new int[n];         
            for( i=1;i<=n;i++)
            {
                numbers[i-1] = i;
            }
            for(i=0;i<n;i++)
            {
                int randomizer = rnd.Next(0, n -1);
                int change = numbers[i];
                numbers[i] = numbers[randomizer];
                numbers[randomizer] = change;
            }
            for(i=0;i<n;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
