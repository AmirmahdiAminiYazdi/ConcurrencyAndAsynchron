using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.TaskSample
{
    public class ContinuationsSample
    {

        public void Start()
        {
            Task<int> sumResult = Task.Run(() => Sum(500, 600));
            var awaiter = sumResult.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                var result = awaiter.GetResult();
                Console.WriteLine($"Sum Result is : {result}");
            });
            Console.WriteLine("Finshed");
            Console.ReadLine();
        }
        public void Start2()
        {
            Task<int> sumResult = Task.Run(() => Sum(500, 600));
            sumResult.ContinueWith(t => Console.WriteLine("After sum"));
            Console.ReadLine();
        }



        public int Sum(int num1, int num2)
        {
            Thread.Sleep(3000);
            return num1 + num2;
        }
    }
}
