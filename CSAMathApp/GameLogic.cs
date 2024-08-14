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

        public static void Subtraction(string difficulty, int questions) 
        {
            if (difficulty == "e")
            {
                Console.WriteLine("Easy Peasy");
            }
            else if (difficulty == "m")
            {
                Console.WriteLine("Medium");
            }
            else if (difficulty == "h")
            {
                Console.WriteLine("Hard.");
            }
            else
            {
                Console.WriteLine("Stop");
            }
        }
        public static void Multiplication(string difficulty, int questions)
        {
            if (difficulty == "e")
            {
                Console.WriteLine("Easy Peasy");
            }
            else if (difficulty == "m")
            {
                Console.WriteLine("Medium");
            }
            else if (difficulty == "h")
            {
                Console.WriteLine("Hard.");
            }
            else
            {
                Console.WriteLine("Stop");
            }
        }

        public static void Division(string difficulty , int questions)
        {
            if (difficulty == "e")
            {
                Console.WriteLine("Easy Peasy");
            }
            else if (difficulty == "m")
            {
                Console.WriteLine("Medium");
            }
            else if (difficulty == "h")
            {
                Console.WriteLine("Hard.");
            }
            else
            {
                Console.WriteLine("Stop");
            }
        }

        public static void AdditionGame(int num1, int num2)
        {
            GameEngine.RandomNumberGen(num1, num2);
            Console.WriteLine($"{num1} {num2}");
            Console.WriteLine("Addition Game started.");
            GameEngine.RandomNumberGen(1, 2);

        }


    }
}
