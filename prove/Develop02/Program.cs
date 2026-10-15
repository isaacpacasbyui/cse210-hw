using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
                choice = 0;
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine() ?? "";

                    // Creativity feature
                    Console.Write("How would you describe your mood today? ");
                    string mood = Console.ReadLine() ?? "";

                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(
                        date,
                        prompt,
                        response,
                        mood
                    );

                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine() ?? "";

                    if (journal.LoadFromFile(loadFilename))
                    {
                        Console.WriteLine("Journal loaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("The file could not be found.");
                    }

                    break;

                case 4:
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine() ?? "";

                    journal.SaveToFile(saveFilename);

                    Console.WriteLine("Journal saved successfully.");
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please choose an option from 1 to 5.");
                    break;
            }
        }
    }
}