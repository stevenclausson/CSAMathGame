using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSAMathApp
{
    public class GameEngine
    {
        Stopwatch stopWatch = new Stopwatch();
        public static void Play()
        {

            Console.WriteLine("Timer STopped!");
            //Thread.Sleep(10000);

        }

        public static void BeginGame(int gameMode)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("COUNTDOWN BEGIN!");
            stopWatch.Start();
            if (gameMode == 1)
            {
                GameLogic.AdditionGame(0,10);
                stopWatch.Stop();
            }
            else if (gameMode == 2)
            {
                stopWatch.Stop();
            }
            else
            {
                Console.WriteLine("WRIONG TEST");
            }

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine($"Runtime: {elapsedTime}");
            Console.ReadLine();
        }

        public static void RandomNumberGen(int min, int max)
        {
            var rand = new Random();
            var output1 = rand.Next(min, max);
            var output2 = rand.Next(min, max);
        }
    }
}
