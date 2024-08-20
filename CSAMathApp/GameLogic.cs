using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSAMathApp
{
    public class GameLogic
    {
        int number;
        List<int> pastScores = new List<int>();
        pastScores.Add(score);
        public static void BeginGame(int game, int questions)
        {
            Stopwatch sw = new Stopwatch();
            int totalCorrect = 0;
            if (game == 1)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(0, 10);
                    int num2 = rnd.Next(0, 10);

                    Console.WriteLine($"{num1} + {num2}");
                    int answer = num1 + num2;
                    bool success = int.TryParse(Console.ReadLine(), out int result);
                    if (success)
                    {
                        if (result == answer)
                        {
                            totalCorrect++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not an answer.");
                        i--;
                        Console.WriteLine(i);
                    }
                }
                sw.Stop();

                // Calculates Stopwatch elapsed time
                TimeSpan ts = sw.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine($"Runtime: {elapsedTime}");
                Console.ReadLine();
                Console.WriteLine($"Total correct: {totalCorrect}");
            }
 
        }

        //-------------THE FOLLOWING IS A TEST-------------------------------------


        public static int TestRandom(int difficulty)
        {
            //Random number gen
            
            Random rnd = new Random();
            int number = rnd.Next((1 * difficulty), (10 * difficulty));
            return number;
            //int num2 = rnd.Next((1 * difficulty), (10 * difficulty));
        }

        public static void TestGame(string game, int difficulty, int questions)
        {
            if (game == "a")
            {
                TestAdditionGame(difficulty, questions);
            }
        }
        public static void TestScoreKeeper(int score)
        {
            //int[] pastScores = new int[] {score};
            
            pastScores.Add(score);
            Console.WriteLine($"Kept Score: {score}");
        }



        public static void TestAdditionGame(int difficulty, int questions)
        {  
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int score = 0;
            for (int i = 0; i < questions; i++)
            {
                int rand1 = TestRandom(difficulty);
                int rand2 = TestRandom(difficulty);
                //int score;
                Console.WriteLine($"{rand1} + {rand2}");
                int answer = rand1 + rand2;
                bool success = int.TryParse(Console.ReadLine(), out int result);
                if (success)
                {
                    if (result == answer)
                    {
                        Console.WriteLine("Correct");
                        score++;
                        Console.WriteLine($"Score: {score}");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Not an answer.");
                }
            }
            sw.Stop();
            // Calculates Stopwatch elapsed time
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            int totalScore = score;
            TestScoreKeeper(totalScore);
            Console.WriteLine($"Runtime: {elapsedTime}, total score: {score}");
            Console.ReadLine();
            GameEngine.StartGame();
        }
    }
}
