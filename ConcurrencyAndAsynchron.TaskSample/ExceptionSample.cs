using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.TaskSample
{
    public class ExceptionSample
    {
        public void Start()
        {
            Task<int> result = Task.Run(() => BadMethod(null, 41));
            try
            {
                result.Wait();
                Console.WriteLine("BadMethod Finished");
            }
            catch (AggregateException ex)
            {

                Console.WriteLine(result.IsCanceled);
                Console.WriteLine(result.IsFaulted);
                Console.WriteLine(ex.Message);
            }
        }
        public int BadMethod(int? num1, int? num2)
        {
            if (num1 == null)
            {
                throw new ArgumentNullException(nameof(num1));
            }
            if (num2 == null)
            {
                throw new ArgumentNullException(nameof(num2));
            }
            return num1.Value + num2.Value;
        }
    }
}
