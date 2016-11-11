using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class StopWatch
    {
        //public string UserInput;
        DateTime time = new DateTime();
        private DateTime startTime;
        private DateTime endTime;
        private TimeSpan elapsTime;

        public void start()
        {
            startTime = DateTime.Now;
            Console.WriteLine("Stop Watch is running...");
        }

        public string stop()
        {
            endTime = DateTime.Now;
            elapsTime = endTime - startTime;
            Console.WriteLine(elapsTime + "\n If you'd like to run the stop watch again type start type stop to quit: ");
            return Console.ReadLine().ToLower();

        }
    }
}
