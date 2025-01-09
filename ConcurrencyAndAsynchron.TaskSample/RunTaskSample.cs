using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.TaskSample
{
    public class RunTaskSample
    {
        public void Start() {

          Task result =   Task.Run(() => PrintName());
            Console.WriteLine("-------Finished-------");
            Console.WriteLine($"Status Result before :{result.Status} ");
            result.Wait();
            Console.WriteLine($"Status Result after :{result.Status} ");
        }
        public void StartCold()
        {
         
            var result = new Task(PrintName);
            Console.WriteLine($"Status before Start :{result.Status} ");
            result.Start();
            Console.WriteLine("-------Finished-------");
            Console.WriteLine($"Status Result before :{result.Status} ");
            result.Wait();
            Console.WriteLine($"Status Result after :{result.Status} ");
        }
        public void StartLongRunning()
        {
            var result = Task.Factory.StartNew(() => PrintName(),TaskCreationOptions.LongRunning);
            Console.WriteLine("-------Finished-------");
            Console.WriteLine($"Status Result before :{result.Status} ");
            result.Wait();
            Console.WriteLine($"Status Result after :{result.Status} ");

        }

        public void PrintName()
        {
            Console.WriteLine($"IsThreadPoolThread :{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"IsBackground :{Thread.CurrentThread.IsBackground}");
            Console.WriteLine($"IsAlive: {Thread.CurrentThread.IsAlive}");
            Thread.Sleep(3000);
            Console.WriteLine("Amir Mahdi Amini Yazdi");
        }
    }
}
