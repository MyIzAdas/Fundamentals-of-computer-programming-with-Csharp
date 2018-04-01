using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows index of letters within the word as in, a-z is 1-26");
            Console.Write("Please enter your word: ");
            string word = Console.ReadLine();
            string[] wArr = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","V","U","W","X","Y","Z","a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "v", "u", "w", "x", "y", "z" };
            int num = 0;
            for (int j = 0; j < word.Length; j++)
            {
                for (int i = 0; i < wArr.Length; i++)
                {
                    if(Convert.ToString(word[j])==wArr[i])
                    {
                        if(i>25)
                        {
                            num = i - 26;
                        }
                        else
                        {
                            num = i;
                        }
                        Console.Write("{0,3}",num+1);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
