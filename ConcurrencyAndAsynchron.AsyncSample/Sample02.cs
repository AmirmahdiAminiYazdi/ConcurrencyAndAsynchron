using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.AsyncSample
{
    public class Sample02
    {
        public async Task PrintAfter10Sec(string message,CancellationToken cancellationToken)
        {
            await Task.Delay(10000,cancellationToken);
            Console.WriteLine(message);
        }
    }
}
