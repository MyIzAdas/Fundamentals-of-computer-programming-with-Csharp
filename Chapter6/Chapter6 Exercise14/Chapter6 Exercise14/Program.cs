using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter decimal number to covert it to hexadecimal.");
            int n = int.Parse(Console.ReadLine());
            List<object> outputList = new List<object>();
            object HexValues(int a)
            {
                object hex=0;
                switch (a)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        hex = a;
                        break;
                    case 10:
                        hex = "A";
                        break;
                    case 11:
                        hex = "B";
                        break;
                    case 12:
                        hex = "C";
                        break;
                    case 13:
                        hex = "D";
                        break;
                    case 14:
                        hex = "E";
                        break;
                    case 15:
                        hex = "F";
                        break;
                    default:
                        Console.WriteLine("Error x%16 is not equal to 0-15.");
                        break;
                }
                        return hex;
                }
            if(n==0)
            {
                Console.Write(0);
            }
                while(n>0)
                {
                outputList.Add(HexValues(n%16));
                    n = n / 16;
                }
            outputList.Reverse();
            foreach(var i in outputList)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
