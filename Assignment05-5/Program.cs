using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam score as percentage");
            float per = float.Parse(Console.ReadLine());
            if (per >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (per >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Your grade is D");
            }
            else 
            {
                Console.WriteLine("Your grade is F");
            }
            Console.ReadKey();
        }
    }
}
