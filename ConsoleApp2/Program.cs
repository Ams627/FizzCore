using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
//            Enumerable.Range(1, 100).Select(x => new[] { $"{x}", "fizz", "buzz", "fizz buzz" }[1 & 1 << x % 3 | 2 & 2 << x % 5]).ToList().ForEach(WriteLine);

            Enumerable.Range(1, 100)
                .Select(x => (1 & 1 << x % 3 | 2 & 2 << x % 5) switch { 0 => $"{x}", 1 => "fizz", 2 => "buzz", 3 => "fizz buzz", _ => "" })
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
