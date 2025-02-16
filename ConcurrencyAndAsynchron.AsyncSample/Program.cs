using ConcurrencyAndAsynchron.AsyncSample;

//var PrimeNumberSample = new PrimeNumberSample();
//PrimeNumberSample.DisplayPrimeNumber();
//Console.ReadLine();
CancellationTokenSource cts = new CancellationTokenSource();
var sample02 = new Sample02();

var task = sample02.PrintAfter10Sec("My Message", cts.Token);
Console.WriteLine("If you want to cancel the task press c");
var cancelResult = Console.ReadLine();
if(cancelResult == "c")
{
    cts.Cancel();
}
try
{
    await task;
}
catch (TaskCanceledException ex)
{

    var status = task.Status;
    var isCanceled = task.IsCanceled;
    Console.WriteLine($"Task is canceled : {isCanceled} & task is status : {status} .");
    Console.WriteLine(ex.Message);
}