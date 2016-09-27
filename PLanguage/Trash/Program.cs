using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Trash
{
    class TimerExample
    {
        static void Main()
        {
            String test = "sykaa";
            test=test.Remove(test.IndexOf("y"), 1);
            Console.WriteLine(test);
        }
    }
}