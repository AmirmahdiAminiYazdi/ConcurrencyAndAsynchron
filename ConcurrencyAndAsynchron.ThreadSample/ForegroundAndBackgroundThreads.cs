using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.ThreadSample
{
    public class ForegroundAndBackgroundThreads
    {
        public void Start()
        {
            Thread thread = new Thread(PrintAndRead);
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine("Main Thread Finshed");
            thread.Join(TimeSpan.FromSeconds(5));
        }
        public void PrintAndRead()
        {
            Console.Write("Please Enter a Word:");
            Console.ReadLine();
        }
    }
}
