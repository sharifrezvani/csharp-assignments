using System;

namespace EleventhAssignmentLevelOne
{
    public enum GameExpressions
    {
        BUST,
        HIT,
        STAND,
        YES,
        NO
    }
    internal class Program
    {


        public static Card RandomCard(List<Card> cardsList)
        {
            Random random = new Random();

            int randomIndex = random.Next(0, cardsList.Count);

            return cardsList[randomIndex];
        }

        public static string AskNextStep()
        {
            Console.WriteLine($"What would you like to do? [HIT, STAND]");
            string? playerChoice = Console.ReadLine().ToUpper();
            return playerChoice;
        }

        static void Main(string[] args)
        {
            List<Card> deck = MakeDeck();

            int dealerScore;
            int playerScore;

            List<Card> dealerCards = new List<Card>();
            List<Card> playerCards = new List<Card>();

            Console.WriteLine("Welcome to Blackjack! Let's see what you got!\n");
            Thread.Sleep(3000);
            Card playerCard1 = RandomCard(deck);
            deck.RemoveAt(deck.FindIndex(card => card == playerCard1));
            Card playerCard2 = RandomCard(deck);
            deck.RemoveAt(deck.FindIndex(card => card == playerCard2));

            playerCards.Add(playerCard1);
            playerCards.Add(playerCard2);


            Card dealerCard1 = RandomCard(deck);
            deck.RemoveAt(deck.FindIndex(card => card == dealerCard1));
            Card dealerCard2 = RandomCard(deck);
            deck.RemoveAt(deck.FindIndex(card => card == dealerCard2));

            dealerCards.Add(dealerCard1);
            dealerCards.Add(dealerCard2);


            Console.WriteLine($"Here are your cards:\n{playerCard1.Name}, {playerCard2.Name}.\n");
            Thread.Sleep(1000);
            Console.WriteLine($"And the dealer's cards:\n{dealerCard1.Name}, and another card which is faced down.\n");
            Thread.Sleep(1000);

            if ((playerCard1.IsAce && playerCard2.Value == 10) || (playerCard2.IsAce && playerCard1.Value == 10))
            {
                if ((dealerCard1.IsAce && dealerCard2.Value == 10) || (dealerCard2.IsAce && dealerCard1.Value == 10))
                {
                    Console.WriteLine($"IT'S A DRAW!");
                    // break;
                }
                else
                {
                    Console.WriteLine($"YOU WON!");
                    // break;
                }
            }

            if ((dealerCard1.IsAce && dealerCard2.Value == 10) || (dealerCard2.IsAce && dealerCard1.Value == 10))
            {
                if ((playerCard1.IsAce && playerCard2.Value == 10) || (playerCard2.IsAce && playerCard1.Value == 10))
                {
                    Console.WriteLine($"IT'S A DRAW!");
                    // break;
                }
                else
                {
                    Console.WriteLine($"YOU LOST!");
                    // break;
                }
            }

            string? playerChoice;

            do
            {
                playerChoice = AskNextStep();
                if (playerChoice.ToUpper() == GameExpressions.STAND.ToString())
                {
                    if (dealerCard1.IsAce)
                    {
                        if (dealerCard2.IsAce)
                        {
                            Card dealerCard3 = RandomCard(deck);
                            
                            deck.RemoveAt(deck.FindIndex(card => card == dealerCard3));

                            dealerCards.Add(dealerCard3);
                        }
                        else
                        {
                            
                        }

                    }
                }
            } while (playerChoice != "STAND" || playerChoice != "HIT");


        }

        public static List<Card> MakeDeck()
        {
            List<Card> cardsList = new List<Card>();

            // Making and Adding the Clubs

            cardsList.Add(new Card(10, Suits.Clubs.ToString(), Faces.King.ToString(), false, "King of Clubs"));
            cardsList.Add(new Card(10, Suits.Clubs.ToString(), Faces.Queen.ToString(), false, "Queen of Clubs"));
            cardsList.Add(new Card(10, Suits.Clubs.ToString(), Faces.Jack.ToString(), false, "Jack of Clubs"));

            cardsList.Add(new Card(10, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Ten of Clubs"));
            cardsList.Add(new Card(9, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Nine of Clubs"));
            cardsList.Add(new Card(8, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Eight of Clubs"));
            cardsList.Add(new Card(7, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Seven of Clubs"));
            cardsList.Add(new Card(6, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Six of Clubs"));
            cardsList.Add(new Card(5, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Five of Clubs"));
            cardsList.Add(new Card(4, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Four of Clubs"));
            cardsList.Add(new Card(3, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Three of Clubs"));
            cardsList.Add(new Card(2, Suits.Clubs.ToString(), Faces.Number.ToString(), false, "Two of Clubs"));
            cardsList.Add(new Card(1, Suits.Clubs.ToString(), Faces.Number.ToString(), true, "Ace of Clubs"));

            // Making and Adding the Spades

            cardsList.Add(new Card(10, Suits.Spades.ToString(), Faces.King.ToString(), false, "King of Spades"));
            cardsList.Add(new Card(10, Suits.Spades.ToString(), Faces.Queen.ToString(), false, "Queen of Spades"));
            cardsList.Add(new Card(10, Suits.Spades.ToString(), Faces.Jack.ToString(), false, "Jack of Spades"));

            cardsList.Add(new Card(10, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Ten of Spades"));
            cardsList.Add(new Card(9, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Nine of Spades"));
            cardsList.Add(new Card(8, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Eight of Spades"));
            cardsList.Add(new Card(7, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Seven of Spades"));
            cardsList.Add(new Card(6, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Six of Spades"));
            cardsList.Add(new Card(5, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Five of Spades"));
            cardsList.Add(new Card(4, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Four of Spades"));
            cardsList.Add(new Card(3, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Three of Spades"));
            cardsList.Add(new Card(2, Suits.Spades.ToString(), Faces.Number.ToString(), false, "Two of Spades"));
            cardsList.Add(new Card(1, Suits.Spades.ToString(), Faces.Number.ToString(), true, "Ace of Spades"));

            // Making and Adding the Diamonds


            cardsList.Add(new Card(10, Suits.Diamonds.ToString(), Faces.King.ToString(), false, "King of Diamonds"));
            cardsList.Add(new Card(10, Suits.Diamonds.ToString(), Faces.Queen.ToString(), false, "Queen of Diamonds"));
            cardsList.Add(new Card(10, Suits.Diamonds.ToString(), Faces.Jack.ToString(), false, "Jack of Diamonds"));

            cardsList.Add(new Card(10, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Ten of Diamonds"));
            cardsList.Add(new Card(9, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Nine of Diamonds"));
            cardsList.Add(new Card(8, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Eight of Diamonds"));
            cardsList.Add(new Card(7, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Seven of Diamonds"));
            cardsList.Add(new Card(6, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Six of Diamonds"));
            cardsList.Add(new Card(5, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Five of Diamonds"));
            cardsList.Add(new Card(4, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Four of Diamonds"));
            cardsList.Add(new Card(3, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Three of Diamonds"));
            cardsList.Add(new Card(2, Suits.Diamonds.ToString(), Faces.Number.ToString(), false, "Two of Diamonds"));
            cardsList.Add(new Card(1, Suits.Diamonds.ToString(), Faces.Number.ToString(), true, "Ace of Diamonds"));

            // Making and Adding the Hearts

            cardsList.Add(new Card(10, Suits.Hearts.ToString(), Faces.King.ToString(), false, "King of Hearts"));
            cardsList.Add(new Card(10, Suits.Hearts.ToString(), Faces.Queen.ToString(), false, "Queen of Hearts"));
            cardsList.Add(new Card(10, Suits.Hearts.ToString(), Faces.Jack.ToString(), false, "Jack of Hearts"));

            cardsList.Add(new Card(10, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Ten of Hearts"));
            cardsList.Add(new Card(9, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Nine of Hearts"));
            cardsList.Add(new Card(8, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Eight of Hearts"));
            cardsList.Add(new Card(7, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Seven of Hearts"));
            cardsList.Add(new Card(6, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Six of Hearts"));
            cardsList.Add(new Card(5, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Five of Hearts"));
            cardsList.Add(new Card(4, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Four of Hearts"));
            cardsList.Add(new Card(3, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Three of Hearts"));
            cardsList.Add(new Card(2, Suits.Hearts.ToString(), Faces.Number.ToString(), false, "Two of Hearts"));
            cardsList.Add(new Card(1, Suits.Hearts.ToString(), Faces.Number.ToString(), true, "Ace of Hearts"));


            return cardsList;
        }
    }
}