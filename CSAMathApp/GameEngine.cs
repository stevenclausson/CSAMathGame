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
        public static void StartGame() 
        {
            InitializeGame();
        }
        
        static void InitializeGame()
        {
            Console.WriteLine("Hello, welcome to the Math Game!");
            Console.WriteLine("Last updated 2024-8-13");
            System.Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            ChooseGame();

        }

        static void ChooseGame()
        {
            Console.WriteLine("Please select which operation you would like to play.");
            Console.WriteLine($@"
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division ");
            string userChoice = Console.ReadLine().ToLower();
            Console.WriteLine("Select difficulty");
            Console.WriteLine($@"
            E - Easy
            M - Medium
            H - Hard ");
            string userDifficulty = Console.ReadLine().ToLower();
            Console.WriteLine("Now, how many questions would you like to answer?");
            int numberOfQuestions = Int32.Parse(Console.ReadLine());
            if (userDifficulty == "e")
            {
                GameLogic.TestGame(userChoice, 1, numberOfQuestions);
            }
            else if(userDifficulty == "m") 
            {
                GameLogic.TestGame(userChoice, 10, numberOfQuestions);
            }
            else if (userDifficulty == "h") 
            {
                GameLogic.TestGame(userChoice, 100, numberOfQuestions);
            }

            //if (userChoice == "a")
            //{
            //    //GameLogic.AdditionGame(userDifficulty, numberOfQuestions);
            //    GameLogic.TestGame(userChoice, numberOfQuestions);
            //}
            //else if (userChoice == "s")
            //{
            //    GameLogic.SubtractionGame(userDifficulty, numberOfQuestions);
            //}
            //else if (userChoice == "m")
            //{
            //    GameLogic.MultiplicationGame(userDifficulty, numberOfQuestions);
            //}
            //else if (userChoice == "d")
            //{
            //    GameLogic.DivisionGame(userDifficulty, numberOfQuestions);
            //}
            //else
            //{
            //    Console.WriteLine("Please try again.");
            //    ChooseGame();
            //}
        }
    }
}
