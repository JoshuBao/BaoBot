using System;
using System.Threading.Tasks;

namespace BaoBot
{
    public class Program
    {
        public static void Main(string[] args)
            => new Program().TaskMain().GetAwaiter().GetResult();

        public async Task TaskMain()
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
