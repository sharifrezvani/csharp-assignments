using System;

namespace EleventhAssignmentLevelOne
{
    public class Card
    {
        public int Value { get; set; }
        public string Suit { get; set; }
        public string Face { get; set; }
        public bool IsAce { get; set; }
        public string Name { get; set; }
        
        
        

        public Card(int value, string suit, string face, bool isAce, string name)
        {
            this.Value = value;
            this.Suit = suit;
            this.Face = face;
            this.IsAce = isAce;
            this.Name = name;
        }
    }

    public enum Suits
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    public enum Faces
    {
        King,
        Queen,
        Jack,
        Number
    }

}