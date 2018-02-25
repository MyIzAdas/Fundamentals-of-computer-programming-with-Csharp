using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string name = Console.ReadLine();
            Console.Write("Company adress: ");
            string adress = Console.ReadLine();
            Console.Write("Company phone number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Company fax number: ");
            string faxNum = Console.ReadLine();
            Console.Write("Company website: ");
            string website = Console.ReadLine();
            Console.Write("Manager's name: ");
            string manaNam = Console.ReadLine();
            Console.Write("Manager's surname: ");
            string manaSur = Console.ReadLine();
            Console.Write("Manager's phone number: ");
            string manaPNum = Console.ReadLine();
            Console.WriteLine("Company name: "+name);
            Console.WriteLine("Company adress: " + adress);
            Console.WriteLine("Company phone number: " + phoneNum);
            Console.WriteLine("Company fax number: " + faxNum);
            Console.WriteLine("Company website: " + website);
            Console.WriteLine("Manager's name: " + manaNam);
            Console.WriteLine("Manager's surname: " + manaSur);
            Console.WriteLine("Manager's phone number: " + manaPNum);
        }
    }
}
