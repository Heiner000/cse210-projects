// EXCEEDS REQUIREMENTS: Program includes a library of scriptures and presents one randomly to the user with each instance.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("S C R I P T U R E   M E M O R I Z E R");

        // EXCEEDS REQUIREMENTS: program works with a library of scriptures to present randomly to the user.
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine bheart; and lean not unto thine own understanding. In all thy ways aacknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory - to bring to pass the immortality and eternal life of man"),
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."),
            new Scripture(new Reference("John", 14, 6), "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."),
            new Scripture(new Reference("James", 1, 5, 6), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.")
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];
        
        while (!scripture.IsCompletelyHidden())
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

                string userInput = Console.ReadLine();

                if (userInput == "quit")
                    break;

                if (!scripture.IsCompletelyHidden())
                {
                    scripture.HideRandomWords(3);
                }
                else
                {
                    break;
                }
            }
        }
    }
}