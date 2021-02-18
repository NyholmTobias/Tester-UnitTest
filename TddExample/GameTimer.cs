using System;
using System.Timers;

namespace TddExample
{
    public class GameTimer
    {
        private static Timer timer;
        static internal int counter = 0;
        public string CountDown(int sek)
        {
            counter = sek;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            while(counter >= 0)
            {
                if (counter == 0)
                {
                    return "Game Over";
                }
            }
            return "fel";
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(counter);
            counter--;
            if(counter == 0)
            {
                timer.Stop();
            }
        }
    }
}