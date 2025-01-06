using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.ThreadSample
{
    public class SharedAndLocalState
    {
        bool allowWrite = true;
        private readonly static object _locker = new object();
        public void Start()
        {
            Thread first = new Thread(SafeCheckedSharedState);
            first.Name = "First Thread";
            Thread second = new Thread(SafeCheckedSharedState);
            second.Name = "Second Thread";

            first.Start();
            second.Start();
            Console.Read();
        }

        public void PrintStar()
        {
            int counter = 10;
            for (int i = 0; counter < 10; i++)
            {
                Console.WriteLine("*");
            }

        }

        public void CheckedSharedState()
        {
            if (allowWrite)
            {
                allowWrite = false;
                Console.WriteLine("This is My Message");
            }
        }

        public void SafeCheckedSharedState()
        {
            lock (_locker)
            {
                if (allowWrite)
                {
                    Console.WriteLine($"Locker Thread Name Is : {Thread.CurrentThread.Name}");
                    allowWrite = false;
                    Console.WriteLine("This is My Message");
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name);

        }
    }
}
