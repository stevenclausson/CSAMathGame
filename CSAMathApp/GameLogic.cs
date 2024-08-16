using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSAMathApp
{
    public class GameLogic
    {
        public static void AdditionGame(string difficulty, int questions)
        {
            if (difficulty == "e")
            {
                Console.WriteLine($"{questions} questions on Easy Peasy mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(1, questions);
            }
            else if (difficulty == "m")
            {
                Console.WriteLine("Medium");
                BeginGame(2, questions);
            }
            else if (difficulty == "h")
            {
                Console.WriteLine("Hard.");
                BeginGame(3, questions);
            }
            else
            {
                Console.WriteLine("Stop. That's not a valid game.");
            }
        }

        public static void SubtractionGame(string difficulty, int questions)
        {
            if (difficulty == "e")
            {
                Console.WriteLine($"{questions} on easy mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(4, questions);
            }
            if (difficulty == "m")
            {
                Console.WriteLine($"{questions} with a little more difficulty, eh? OK.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(5, questions);
            }
            if (difficulty == "h")
            {
                Console.WriteLine($"{questions} on hard mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(6, questions);
            }
        }

        public static void MultiplicationGame(string difficulty, int questions)
        {
            if (difficulty == "e")
            {
                Console.WriteLine($"{questions} on easy mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(7, questions);
            }
            if (difficulty == "m")
            {
                Console.WriteLine($"{questions} with a little more difficulty, eh? OK.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(8, questions);
            }
            if (difficulty == "h")
            {
                Console.WriteLine($"{questions} on hard mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(9, questions);
            }
        }

        public static void DivisionGame(string difficulty, int questions)
        {
            if (difficulty == "e")
            {
                Console.WriteLine($"{questions} on easy mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(10, questions);
            }
            if (difficulty == "m")
            {
                Console.WriteLine($"{questions} with a little more difficulty, eh? OK.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(11, questions);
            }
            if (difficulty == "h")
            {
                Console.WriteLine($"{questions} on hard mode? Got it.");
                Console.WriteLine("Press any key to begin!");
                Console.ReadLine();
                BeginGame(12, questions);
            }
        }

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
            else if (game == 2)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(10, 100);
                    int num2 = rnd.Next(10, 100);

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
            else if (game == 3)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(100, 1000);
                    int num2 = rnd.Next(100, 1000);

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

            else if (game == 4)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(1, 10);
                    int num2 = rnd.Next(1, 10);

                    Console.WriteLine($"{num1} - {num2}");
                    int answer = num1 - num2;
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

            else if (game == 5)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(10, 100);
                    int num2 = rnd.Next(100, 1000);

                    Console.WriteLine($"{num1} - {num2}");
                    int answer = num1 - num2;
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
            else if (game == 6)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(100, 1000);
                    int num2 = rnd.Next(100, 1000);

                    Console.WriteLine($"{num1} - {num2}");
                    int answer = num1 - num2;
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
            else if (game == 7)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(1, 10);
                    int num2 = rnd.Next(1, 10);

                    Console.WriteLine($"{num1} * {num2}");
                    int answer = num1 * num2;
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
            else if (game == 8)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(10, 100);
                    int num2 = rnd.Next(10, 100);

                    Console.WriteLine($"{num1} * {num2}");
                    int answer = num1 * num2;
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
            else if (game == 9)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(100, 1000);
                    int num2 = rnd.Next(100, 1000);

                    Console.WriteLine($"{num1} * {num2}");
                    int answer = num1 * num2;
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
            else if (game == 10)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(1, 10);
                    int num2 = rnd.Next(1, 10);

                    Console.WriteLine($"{num1} / {num2}");
                    int answer = num1 / num2;
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
            else if (game == 11)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(10, 100);
                    int num2 = rnd.Next(10, 100);

                    Console.WriteLine($"{num1} / {num2}");
                    int answer = num1 / num2;
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
            else if (game == 12)
            {
                sw.Start();
                Random rnd = new Random();
                for (int i = 0; i < questions; i++)
                {
                    int num1 = rnd.Next(100, 1000);
                    int num2 = rnd.Next(100, 1000);

                    Console.WriteLine($"{num1} / {num2}");
                    int answer = num1 / num2;
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

        public static void TestGame(string choice)
        {

            if (choice == "a")
            {
                TestDifficultyCheck("a");
            }
            else
            {
                Console.WriteLine("Another choice.");
            }
            ////Create and start stopwatch
            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            ////variable for total correct answers
            //int totalCorrect = 0;


            ////Begin question loop
            //for (int i = 0; i < questions; i++)
            //{
            //    if (choice == "a")
            //    {
            //        Console.WriteLine("Add Me");
            //    }
            //    else if (choice == "s")
            //    {

            //    }

            //    else
            //        Console.WriteLine("Fail");
            //}
            // //stops stopwatch
            // sw.Stop();
            //// Calculates Stopwatch elapsed time
            //TimeSpan ts = sw.Elapsed;
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);
            //Console.WriteLine($"Runtime: {elapsedTime}");
            //Console.ReadLine();
            //Console.WriteLine($"Total correct: {totalCorrect}");

        }

        public static void TestRandom(int rand1, int rand2, string game)
        {
            //Random number gen
            Random rnd = new Random();
            int num1 = rnd.Next(rand1, rand2);
            int num2 = rnd.Next(rand1, rand2);
            TestNumberOfQuestions(num1, num2, game);
        }

        public static void TestDifficultyCheck(string game)
        {
            Console.WriteLine("Select difficulty");
            Console.WriteLine($@"
            E - Easy
            M - Medium
            H - Hard ");
            string userDifficulty = Console.ReadLine().ToLower();
            if (userDifficulty == "e")
            {
                TestRandom(1, 10, game);
            }
            else if (userDifficulty == "m")
            {
                TestRandom(10, 100, game);
            }
            else if ( userDifficulty == "h")
            {
                TestRandom(100, 1000, game);
            }
        }

        public static void TestMath(int rand1, int rand2, string game, int questions)
        {
            if (game == "a")
            {
                Console.WriteLine($"{rand1} + {rand2}");
                int answer = rand1 + rand2;
                bool success = int.TryParse(Console.ReadLine(), out int result);
                if (success)
                {
                    if (result == answer)
                    {
                        Console.WriteLine("Correct");
                        TestScoreKeeper(1);
                    }
                }
                else
                {
                    Console.WriteLine("Not an answer.");
                }
            }
        }
        public static void TestScoreKeeper(int correct)
        {
            int score = 0;
            score += correct;
            Console.WriteLine($"Score: {score}");
        }

        public static void TestNumberOfQuestions(int num1, int num2, string game)
        {
            Console.WriteLine("Now, how many questions would you like to answer?");
            int numberOfQuestions = Int32.Parse(Console.ReadLine());
            TestMath(num1, num2, game, numberOfQuestions);

        }

        public static void TestAdditionGame()
        {

        }
    }
}
