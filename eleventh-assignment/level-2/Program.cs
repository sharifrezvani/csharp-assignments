using System;

namespace EleventhAssignmentLevelTwo
{
    public class Player
    {
        public string Symbol { get; set; }

        public string Name { get; set; }

    }
    internal class Program
    {

        static public void DrawTable(List<string> choicesList)
        {
            Console.WriteLine(@"
      |      |
  {0}   |  {1}   |  {2}
______|______|______
      |      |
  {3}   |  {4}   |  {5}
______|______|______
      |      |
  {6}   |  {7}   |  {8}
      |      |
", choicesList[0], choicesList[1], choicesList[2], choicesList[3], choicesList[4], choicesList[5], choicesList[6], choicesList[7], choicesList[8]);

        }

        static public bool LookForWinner(List<string> choicesList)
        {

            if (choicesList[0] == choicesList[1] && choicesList[1] == choicesList[2])
            {
                return true;
            }
            else if (choicesList[3] == choicesList[4] && choicesList[4] == choicesList[5])
            {
                return true;
            }
            else if (choicesList[6] == choicesList[7] && choicesList[7] == choicesList[8])
            {
                return true;
            }
            else if (choicesList[0] == choicesList[3] && choicesList[3] == choicesList[6])
            {
                return true;
            }
            else if (choicesList[1] == choicesList[4] && choicesList[4] == choicesList[7])
            {
                return true;
            }
            else if (choicesList[2] == choicesList[5] && choicesList[5] == choicesList[8])
            {
                return true;
            }
            else if (choicesList[0] == choicesList[4] && choicesList[4] == choicesList[8])
            {
                return true;
            }
            else if (choicesList[2] == choicesList[4] && choicesList[4] == choicesList[6])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first player's name (X):");
            Player player1 = new Player() { Symbol = "X", Name = Console.ReadLine() };

            Console.WriteLine("Enter the second player's name (O):");
            Player player2 = new Player() { Symbol = "O", Name = Console.ReadLine() };

            List<string> choiceList = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


            int turnCounter = 1;

            while (turnCounter < 10)
            {

                Console.WriteLine("-----------------------------------------");

                if (turnCounter % 2 == 1)
                {
                    DrawTable(choiceList);
                    Console.WriteLine($"{player1.Name}'s turn! Choose a position:");

                    string playersChoice = Console.ReadLine();

                    if (!choiceList.Contains(playersChoice))
                    {
                        Console.WriteLine("Invalid Choice! Try Again!");
                    }
                    else
                    {
                        for (var i = 0; i < choiceList.Count; i++)
                        {
                            if (choiceList[i] == playersChoice)
                            {
                                choiceList[i] = "X";

                                turnCounter++;
                                break;
                            }

                        }
                    }

                }
                else
                {
                    DrawTable(choiceList);
                    Console.WriteLine($"{player2.Name}'s turn! Choose a position:");

                    string playersChoice = Console.ReadLine();

                    if (!choiceList.Contains(playersChoice))
                    {
                        Console.WriteLine("Invalid Choice! Try Again!");
                    }
                    else
                    {
                        for (var i = 0; i < choiceList.Count; i++)
                        {
                            if (choiceList[i] == playersChoice)
                            {
                                choiceList[i] = "O";

                                turnCounter++;
                                break;
                            }

                        }
                    }

                }
                

                Console.WriteLine("-----------------------------------------");


                if (LookForWinner(choiceList))
                {
                    DrawTable(choiceList);

                    if ((turnCounter - 1) % 2 == 1)
                    {
                        Console.WriteLine($"{player1.Name} WON!");
                    }
                    else if ((turnCounter - 1) % 2 == 0)
                    {
                        Console.WriteLine($"{player2.Name} WON!"); 
                    }


                    Console.WriteLine($"Finished!");

                    break;

                }

            }



        }
    }
}