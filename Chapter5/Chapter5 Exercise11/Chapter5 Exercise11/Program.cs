using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 999 and this program will type it in English.");
            int n = int.Parse(Console.ReadLine());
            void Numbers(int a)
            {
                switch (a)
                {
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                    case 10:
                        Console.Write("ten ");
                        break;
                    case 11:
                        Console.Write("eleven ");
                        break;
                    case 12:
                        Console.Write("twelve ");
                        break;
                    case 13:
                        Console.Write("thirteen ");
                        break;
                    case 14:
                        Console.Write("fourteen ");
                        break;
                    case 15:
                        Console.Write("fifteen ");
                        break;
                    case 16:
                        Console.Write("sixteen ");
                        break;
                    case 17:
                        Console.Write("seventeen ");
                        break;
                    case 18:
                        Console.Write("eighteen ");
                        break;
                    case 19:
                        Console.Write("nineteen ");
                        break;
                }
            }
                void Tens(int b)
                {
                    switch(b)
                        {
                        case 2:
                            Console.Write(" twenty ");
                            break;
                        case 3:
                            Console.Write(" thirty ");
                            break;
                        case 4:
                            Console.Write(" fourty ");
                            break;
                        case 5:
                            Console.Write(" fifty ");
                            break;
                        case 6:
                            Console.Write(" sixty ");
                            break;
                        case 7:
                            Console.Write(" seventy ");
                            break;
                        case 8:
                            Console.Write(" eighty ");
                            break;
                        case 9:
                            Console.Write(" ninety ");
                            break;
                    }
                }
            if(n==0)
            {
                Console.WriteLine("Zero");
            }
            if (n / 100 > 0)
            {
                Numbers(n / 100);
                Console.Write(" hundred ");
                if((n/10)%10>1)
                {
                    Tens((n / 10)%10);
                    Numbers(n % 10);
                }
                else
                {
                    Numbers(n%100);
                }
            }
            else
            {
                if ((n / 10) % 10 > 1)
                {
                    Tens((n / 10) % 10);
                    Numbers(n % 10);
                }
                else
                {
                    Numbers(n);
                }
            }
            Console.WriteLine();
        }
    }
}
