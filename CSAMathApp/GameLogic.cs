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
            else if (game == "s")
            {
                TestSubtractionGame(difficulty, questions);
            }
            else if (game == "m")
            {
                TestMultiplicationGame(difficulty, questions);
            }
            else if (game == "d")
            {
                TestDivisionGame(difficulty, questions);
            }
            else if (game == "x")
            {
                Console.WriteLine("Goodbye.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yea, that's not a choice.");
                TestGame(game, difficulty, questions);
            }
                

        }
        public static void TestScoreKeeper(int score)
        {
            //int[] pastScores = new int[] {score};
            
            //pastScores.Add(score);
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
        public static void TestSubtractionGame(int difficulty, int questions)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int score = 0;
            for (int i = 0; i < questions; i++)
            {
                int rand1 = TestRandom(difficulty);
                int rand2 = TestRandom(difficulty);
                //int score;
                Console.WriteLine($"{rand1} - {rand2}");
                int answer = rand1 - rand2;
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
        public static void TestMultiplicationGame(int difficulty, int questions)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int score = 0;
            for (int i = 0; i < questions; i++)
            {
                int rand1 = TestRandom(difficulty);
                int rand2 = TestRandom(difficulty);
                //int score;
                Console.WriteLine($"{rand1} * {rand2}");
                int answer = rand1 * rand2;
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
        public static void TestDivisionGame(int difficulty, int questions)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int score = 0;
            for (int i = 0; i < questions; i++)
            {
                int rand1 = TestRandom(difficulty);
                int rand2 = TestRandom(difficulty);
                //int score;
                Console.WriteLine($"{rand1} / {rand2}");
                int answer = rand1 / rand2;
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
