using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <4; n++)
            {
                for (int i = 1; i <= 13; i++)
                {


                    if (i <= 9)
                    {
                        Console.Write(i);
                    }
                    if (i > 9)
                    {
                        switch (i)
                        {
                            case 10:
                                Console.Write("J");
                                break;
                            case 11:
                                Console.Write("Q");
                                break;
                            case 12:
                                Console.Write("K");
                                break;
                            case 13:
                                Console.Write("A");
                                break;
                        }
                    }
                    switch (n)
                    {
                        case 0:
                            Console.WriteLine(" of clubs");
                            break;
                        case 1:
                            Console.WriteLine(" of diamonds");
                            break;
                        case 2:
                            Console.WriteLine(" of hearts");
                            break;
                        case 3:
                            Console.WriteLine(" of spades");
                            break;

                    }
                }
            }
        }
    }
}
