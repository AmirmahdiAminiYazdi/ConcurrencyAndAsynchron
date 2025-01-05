using ConcurrencyAndAsynchron.ThreadSample;

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

