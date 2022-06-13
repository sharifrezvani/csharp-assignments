using System;
using System.Collections.Generic;

namespace HangManGame
{
    class Program
    {
        private static void HangMan(int wrongAttempts)
        {

            switch (wrongAttempts)
            {
                case 0:
                    Console.WriteLine(@"#=====#
|     |
|
|
|
|
#============#");
                    break;
                case 1:
                    Console.WriteLine(@"#=====#
|     |
|     O
|
|
|
#============#");
                    break;
                case 2:
                    Console.WriteLine(@"#=====#
|     |
|     O
|     |
|
|
#============#");
                    break;
                case 3:
                    Console.WriteLine(@"#=====#
|     |
|     O
|    /|
|
|
#============#");
                    break;
                case 4:
                    Console.WriteLine(@"#=====#
|     |
|     O
|    /|\
|
|
#============#");
                    break;
                case 5:
                    Console.WriteLine(@"#=====#
|     |
|     O
|    /|\
|    /
|
#============#");
                    break;
                case 6:
                    Console.WriteLine(@"#=====#
|     |
|     O
|    /|\
|    / \
|
#============#");
                    break;
                default:
                    break;
            }

        }

        public static string RandomWordPicker(List<string> wordList)
        {

            Random random = new Random();

            int randomIndex = random.Next(wordList.Count);

            string randomWord = wordList[randomIndex];

            return randomWord;
        }



        static void Main(string[] args)
        {

            List<string> wordList = new List<string> { "RANDOM", "PLAYER", "FRIEND", "ORANGE", "GROW", "ALIVE" };

            string randomWord = RandomWordPicker(wordList);

            int wrongAttempts = 0;

            List<char> correctGuessList = new List<char>();


            List<char> allGuessList = new List<char>();



            while (wrongAttempts < 6 && correctGuessList.Count < randomWord.Length)
            {

                Console.WriteLine();

                foreach (var item in randomWord)
                {
                    if (correctGuessList.Contains(item))
                    {
                        Console.Write(item);
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine("\nDon't let him die!\nGuess a letter:");


                char guessedLetter = Convert.ToChar(Console.ReadLine().ToUpper());


                if (allGuessList.Contains(guessedLetter))
                {
                    Console.WriteLine($"You already guessed {guessedLetter}.");

                }
                else
                {
                    allGuessList.Add(guessedLetter);

                    bool correctGuess = false;

                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (guessedLetter == randomWord[i])
                        {
                            correctGuess = true;
                        }
                    }

                    if (correctGuess)
                    {

                        Console.WriteLine("\nCorrect!");
                        HangMan(wrongAttempts);
                        correctGuessList.Add(guessedLetter);

                    }
                    else
                    {
                        Console.WriteLine("\nWrong!");
                        wrongAttempts++;
                        HangMan(wrongAttempts);
                        allGuessList.Add(guessedLetter);

                    }

                    if (correctGuessList.Count == randomWord.Length)
                    {
                        Console.WriteLine("Congrats, you won!");
                        
                    }
                    else if (wrongAttempts == 6)
                    {
                        Console.WriteLine("You lost. Try again.");

                    }
                }
            }
        }
    }
}
