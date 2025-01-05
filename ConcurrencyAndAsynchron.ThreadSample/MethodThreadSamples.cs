namespace ConcurrencyAndAsynchron.ThreadSample
{
    public class MethodThreadSamples()
    {
        public void CreateThreadSample()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Name = "dashPrinterWorker";
            Console.WriteLine($"{dashPrinterWorker.Name} is alive before start: {dashPrinterWorker.IsAlive}");

            dashPrinterWorker.Start();

            Console.WriteLine($"{dashPrinterWorker.Name} is alive after start: {dashPrinterWorker.IsAlive}");

            charPrinter.printStar();

            Console.WriteLine($"{dashPrinterWorker.Name} is alive after print STAR: {dashPrinterWorker.IsAlive}");
            Console.ReadLine();
            Console.WriteLine($"{dashPrinterWorker.Name} is alive after readline: {dashPrinterWorker.IsAlive}");

        }
        public void JoinSample()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            var result = dashPrinterWorker.Join(100);
            Console.WriteLine(result);
            dashPrinterWorker.Start();

            charPrinter.printStar();
            Console.ReadLine();
        }
        public void SleepSample()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Start();
            charPrinter.printStar();
           // Thread.Sleep(20000);
            Console.ReadLine();
        }

        public void TreadStateCheck()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Start();
            Console.WriteLine(dashPrinterWorker.ThreadState);
            var isBlock = (dashPrinterWorker.ThreadState & ThreadState.WaitSleepJoin) != 0;
            Console.WriteLine($"Dash printer worker is block? {isBlock}");
        }
    }
}