using System;
using SubModCommon;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(TestEnum));
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
