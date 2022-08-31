using System;
namespace SecondUppgift
{
    class program
    {
        static bool programQuit = false;
        static void Main(string[] args)
        {
            while (programQuit == false)
            {
                MainMenuText();
                UserChoise(UserInput());
            }
        }

        static void MainMenuText()
        {
            Console.WriteLine("Gör ditt Val:");
            Console.WriteLine("1: Skriv ut 1 till 100.");
            Console.WriteLine("2: Skriv ut 100 till 1.");
            Console.WriteLine("3: Avsluta Program");
        }
        static int UserInput()
        {
            string? inputString = Console.ReadLine();
            int inputNum;
            Int32.TryParse(inputString, out inputNum);
            return inputNum;
        }
        static void UserChoise(int UserInput)
        {
            switch (UserInput)
            {
                case 1:
                    Console.WriteLine("Du har gjort Val 1:");
                    Counter(true);
                    break;
                case 2:
                    Console.WriteLine("Du har gjort Val 2:");
                    Counter(false);
                    break;
                case 3:
                    Console.WriteLine("Program Avslutas:");
                    programQuit = true;
                    break;
                default:
                    Console.WriteLine("Dit val är ej giltigt, prova igen.");
                    UserChoise(UserInput);
                    break;

            }
            static void Counter(bool countUp)
            {
                if (countUp == true)
                {
                    for (int i = 0, j = 0; i + j <= 200; i++, j++)
                    {
                        Console.WriteLine("i = {0} and j = {1}", i, j);
                    }
                }
                else
                {
                    for (int i = 100, j = 100; i + j >= 0; i--, j--)
                    {
                        Console.WriteLine("i = {0} and j = {1}", i, j);

                    }

                }
                
            }
        }

    }
}


