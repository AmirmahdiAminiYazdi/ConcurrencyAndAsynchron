namespace ConcurrencyAndAsynchron.ThreadSample
{
    public class ThreadPrioritySample
    {
        public void Start()
        {
            Thread T1 = new(()=> ThreadPrinter("*"));
            T1.Priority = ThreadPriority.Highest;
            Thread T2 = new(() => ThreadPrinter("/"));
            Thread T3 = new(() => ThreadPrinter("#"));
            T3.Priority = ThreadPriority.Highest;
            T1.Start();
            T2.Start();
            T3.Start();


        }
        public void ThreadPrinter(string input)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(input);
            }
        }
    }
}
