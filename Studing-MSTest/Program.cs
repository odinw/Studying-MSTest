using System;

namespace Studing_MSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            var sum = calculate.Add(1, 2);
            Console.WriteLine($"sum : {sum}");
        }
    }
}
