using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("To start the stop Watch, enter start: ");
            var stopWatch = new StopWatch();
            var userInput = Console.ReadLine();
            while (userInput == "start")
            {
                stopWatch.start();
                userInput = Console.ReadLine();
            }
                //this end method
                stopWatch.stop();
            
            
        }
    }
}
