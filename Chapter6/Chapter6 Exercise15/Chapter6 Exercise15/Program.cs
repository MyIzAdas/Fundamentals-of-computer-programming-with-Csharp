using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter hexadecimal(Capital characters) number you want to convert it to decimal and press \"Enter\"");
            string n = Console.ReadLine();
            double dec = 0;
            int backwCycle = n.Length-1;
            int minusPower = 0;
            bool isDecPoint=false;
            int HexToInt(char a)
            {
                int num = 0;
               if(Convert.ToInt32(a)<=57 && Convert.ToInt32(a)>=48)
                {
                    num = Convert.ToInt32(a-48);
                }
               else
                {
                    switch(a)
                    {
                        case '.':
                            break;
                        case 'A':
                            num = 10;
                            break;
                        case 'B':
                            num = 11;
                            break;
                        case 'C':
                            num = 12;
                            break;
                        case 'D':
                            num = 13;
                            break;
                        case 'E':
                            num = 14;
                            break;
                        case 'F':
                            num = 15;
                            break;
                        default:
                            Console.WriteLine("Value for DexToInt must be in combination with one of these: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F.");
                    break;
                         }
                }
                return num;
            }
            for (int b = 0;b<n.Length;b++)
            {
                if(n[b]=='.')
                {
                    isDecPoint = true;
                }
            }
            for(int i=0;i<n.Length;i++)
            {
                if (isDecPoint == false)
                {
                    dec = dec + HexToInt(n[i]) * Math.Pow(16, backwCycle);
                    backwCycle--;
                }
                if (isDecPoint==true && n[i]!='.')
                {
                    dec = dec + HexToInt(n[i]) * Math.Pow(16, minusPower);
                    minusPower--;
                }
            }
            Console.WriteLine(dec);
           }
    }
}
