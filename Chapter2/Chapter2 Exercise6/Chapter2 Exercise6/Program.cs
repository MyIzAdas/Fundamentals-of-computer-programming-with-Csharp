using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale;
            Console.WriteLine("Press 1 and \"Enter\" if you are male, press 2 and \"Enter\" if you are female");
            int maleOrFemale;
            maleOrFemale=Convert.ToInt32(Console.ReadLine());
            if(maleOrFemale==1)
            {
                isMale = true;
            }
            else
            {
                isMale = false;
            }
            Console.WriteLine(isMale);
        }
    }
}
