using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Test2805
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var fruits = new List<string>
            {
                "Apple",
                "Banana",
                "Orange",
                "Lemon"
            };

            var result = fruits
                .Where(f => f.Length == 5)
                .Select(f=>string.Concat(f.Reverse()));

            var result2 = from f in fruits where f.Length == 5 select f;

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
