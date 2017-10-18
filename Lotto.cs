using System;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            var liczba = Enumerable.Range(0, 49).Select(x => ++x).OrderBy(x => Guid.NewGuid()).Take(6).ToList();
            foreach (var item in liczba)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}