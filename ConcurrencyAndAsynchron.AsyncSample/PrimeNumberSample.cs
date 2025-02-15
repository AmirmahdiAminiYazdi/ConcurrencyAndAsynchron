using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.AsyncSample
{
    public class PrimeNumberSample
    {


        public async void DisplayPrimeNumber()
        {
            int count = 1_000_000;

            for (int i = 0; i < 10; i++)
            {
                int start = i * count + 2;
                int itemCount = count - 3;
                Console.WriteLine($"There are {await GetPrimeNumberCountAsync(start,count)}between {start} and {count}");
            }
        }
        private Task<int> GetPrimeNumberCountAsync(int startFrom, int count)
        {
            return Task.Run(() => Enumerable.Range(startFrom, count)
            .Count(c => Enumerable.Range(2, (int)(Math.Sqrt(c) - 1))
            .All(d => c % d != 0)));

        }
    }
}
