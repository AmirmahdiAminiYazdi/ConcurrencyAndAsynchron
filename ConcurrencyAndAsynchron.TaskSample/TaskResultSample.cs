public class TaskResultSample
{

    public void Start()
    {
        Task<int> result = Task.Run(() => Add(500, 444));
        Console.WriteLine($"Result Status before :{result.Status} ");
        var sum = result.Result;
        Console.WriteLine($"Result Status after :{result.Status} ");
        Console.WriteLine(sum.ToString());
        Console.WriteLine("Finished");



    }
    public int Add(int input01 , int inpunt02)
    {
        Thread.Sleep(3000);
        return  input01 + inpunt02;
        
    }
}
