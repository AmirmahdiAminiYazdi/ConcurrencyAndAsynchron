using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.ThreadSample
{
    public class PassDataSample
    {


        public void Start()
        {
            Thread worker = new Thread(() => PrintFullName("Amir Mahdi", "Amini Yazdi"));
            worker.Start();
            Console.Read();
        }
        public void CaptureVariableProblerm()
        {
            string fullName = "Kimia Jafari";
            Thread firstThread = new Thread(() => Console.WriteLine(fullName));
            fullName = "Amir Mahdi Amini Yazdi";
            Thread secondThread = new Thread(() => Console.WriteLine(fullName));
            firstThread.Start();
            secondThread.Start();
            Console.Read();
        }
        public void PrintNumber(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int temp = i;
                new Thread(() => Console.WriteLine(i)).Start();
            }
        }
            public void ObjectSampleInStart()
            {
                Thread worker = new Thread(PrintObject);
                var hello = "Hello World";
                worker.Start(hello);
                Console.Read();
            }
            public void PrintObject(object obj)
            {
                Console.WriteLine(obj.ToString());
            }
            public void PrintFullName(string firstName, string lastName)
            {
                Console.WriteLine($"FullName Is : {firstName} {lastName}");
            }
        }
    }
