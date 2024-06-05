using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("Let's Look at some Events");

        Address address1 = new Address("123 Main St", "Mesa", "AZ", "USA");
        Address address2 = new Address("500 Rua Principal", "Sao Paulo", "SP", "Brazil");
        Address address3 = new Address("999 Yellowstone Trail", "Jackson", "WY", "USA");

        Lecture lecture = new Lecture("Living in the Heat", "A deep dive into taking the edge of the summer heat in the Phoenix Valley.", "06-15-24", "1600H", address1, "Dr. Sandie Somers", 150);

        Reception reception = new Reception("Carnaval Reception", "An opportunity to rub shoulders with professional party throwers with Brazilian's Carnaval!", "03-01-25", "2000H", address2, "rsvp@carnaval.br");

        Outdoor outdoor = new Outdoor("Breakfast with the Bears", "Come grab some pancakes and feed the bear cubs at Yellowstone's rehabilitation reserve.", "07-24-24", "0830H", address3, "Sunny Skies");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            DisplayEventDetails(e);
            Console.WriteLine();
        }

        void DisplayEventDetails(Event e)
        {
            Console.WriteLine("~ Standard Details ~ ");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("~ Full Deets ~");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("~ Short Description ~");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }

    }
}