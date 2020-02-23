using System;

namespace Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int convertNumber = int.Parse(number);
            int i = convertNumber - 1;

            while (convertNumber % i != 0)
            {
                i--;
            }
            Console.WriteLine(i);
        }
    }
}
