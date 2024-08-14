using CSAMathApp;
using System.Diagnostics;
using System.IO.Pipes;


InitializeGame();
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
    if (userChoice == "a")
    {
        Console.WriteLine("Please.");
        AdditionGame(userDifficulty, numberOfQuestions);
    }
    else if (userChoice == "s")
    {
        //SubtractionGame(userDifficulty, numberOfQuestions);
    }
    else if (userChoice == "m")
    {
        //MultiplicationGame(userDifficulty, numberOfQuestions);
    }
    else if (userChoice == "d")
    {
        //DivisionGame(userDifficulty, numberOfQuestions);
    }
    else
    {
        Console.WriteLine("Please try again.");
        ChooseGame();
    }
}

static void AdditionGame(string difficulty, int questions)
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
    }
    else
    {
        Console.WriteLine("Stop");
    }
}

static void BeginGame(int game, int questions)
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
            int userAnswer = Int32.Parse(Console.ReadLine());
            if (userAnswer == answer)
            {
                totalCorrect++;
            }
            Console.WriteLine($"Total correct: {totalCorrect}");
        }
    }
    else if (game == 2)
    {

    }
    else if (game == 3)
    {

    }
}


//Integer Only
// +
// - 
// *
// /
//Game has timer
//Random game with random operations
//store previous games in a List.

//DONE User enters difficulty
//DONE Function to pick number of questions


