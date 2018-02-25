using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rez;
            int rez2=n;
            int bit3 = 8 << 21;
            int bit4 = 16 << 21;
            int bit5 = 32 << 21;
            if ((n & 8) == 0)
            {
                rez = n & ~bit3;
            }
            else
            {
                rez = n | bit3;
            }
            if ((n& bit3)==0)
            {
                rez = rez & ~8;
            }
            else
            {
                rez = rez | 8;
            }
            if ((n & 16) == 0)
            {
                rez = rez & ~bit4;
            }
            else
            {
                rez = rez | bit4;
            }
            if ((n & bit4) == 0)
            {
                rez = rez & ~16;
            }
            else
            {
                rez = rez | 16;
            }
            if ((n & 32) == 0)
            {
                rez = rez & ~bit5;
            }
            else
            {
                rez = rez | bit5;
            }
            if ((n & bit5) == 0)
            {
                rez = rez & ~32;
            }
            else
            {
                rez = rez | 32;
            }
            for (int i=8; i<33; i=i*2)          //Exercise 16
            {
                if ((n & i) == 0)
                {
                    rez2 = rez2 & ~(i<<21);
                }
                else
                {
                    rez2 = rez2 | (i<<21);
                }
                if ((n & (i<<21)) == 0)
                {
                    rez2 = rez2 & ~i;
                }
                else
                {
                    rez2 = rez2 | i;
                }
            }
            Console.WriteLine("Exercise 15 result: "+rez);
            Console.WriteLine("Exercise 16 result: "+rez2);
        }
    }
}
