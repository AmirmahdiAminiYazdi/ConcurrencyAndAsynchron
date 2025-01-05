using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchron.ThreadSample
{
    public class CharPrinter
    {
        public void printStar()
        {
            for (int i = 0; i < 1000; i++) { Console.Write("*"); }
        }
        public void PrintDash() { for (int i = 0; i < 1000; i++) { Console.Write("-"); } }
    }
}