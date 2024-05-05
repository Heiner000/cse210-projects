// EXCEEDS CORE REQUIREMENTS: Displays the number of journal entries.

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!!");

        int menuOption;
        Journal myJournal = new Journal();
        PromptGenerator prompter = new PromptGenerator();

        do 
        {
            Console.WriteLine($"\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write($"\nWhat would you like to do? ");
            string userInput = Console.ReadLine();

            menuOption = int.Parse(userInput);

            if (menuOption == 1)
            {
                // display random prompt from list
                string prompt = prompter.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine(prompt);
                
                // allow user to respond
                Console.Write(">>> ");
                string response = Console.ReadLine();
                
                // save response, prompt, and date as Entry
                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response,
                };

                myJournal.AddEntry(entry);
            }
            else if (menuOption == 2)
            {
                // iterate through all entries in the journal and display them to the screen
                myJournal.DisplayAll();
            }
            else if (menuOption == 3) // Load
            {
                // prompt user for filename
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();

                // iterate through and display entries from that file
                myJournal.LoadFromFile(file);
                Console.WriteLine($"\nLoaded file ~ {file} ~.");

                // EXCEEDS CORE: Displays how many entries the user has in the journal.
                Console.WriteLine($"\nNumber of entries: {myJournal._entries.Count}.");
            }
            else if (menuOption == 4) // Save
            {
                // prompt user for filename
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                
                // save current list of entries to that file
                myJournal.SaveToFile(file);
                Console.WriteLine($"\nSaved to ~ {file} ~.\n");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

        } while (menuOption != 5);
        
        
    }
}