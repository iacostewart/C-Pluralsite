using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("your Name");
            string name = Console.ReadLine();

            Console.WriteLine("how many hours of sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
                

            Console.WriteLine("hello " + name );
              if(hoursOfSleep >= 8)
            {
                Console.WriteLine("you are well rested");
            } else
            {
                Console.WriteLine("you need more sleep");
            }

        }
    }
}
