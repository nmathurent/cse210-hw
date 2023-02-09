using System;

class Program
{
    static void Main(string[] args)
    {
        int randVerse;
        string menuOption = "0";    

        JohnBook11 bookOfJohn = new JohnBook11();
        MarkBook8 bookOfMark = new MarkBook8();
        LukeBook2 bookOfLuke = new LukeBook2();
        MatthewBook18 bookOfMatthew = new MatthewBook18();

        // Instantiate random number generator
        // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
        Random rand = new Random();

        // Choose a ramdom number between 1 and 4 to select the book
        int randBook = rand.Next(4) == 0 ? 1 : rand.Next(4);
        randBook = 1;  // borrar

        // Choose a ramdom number between 1 and 5 to select the initial verse
        randVerse = rand.Next(5);
        int randIniVers = randVerse == 0 ? 1 : randVerse;
        randIniVers = 2; // borrar

        // Choose a ramdom number between 1 and 5 to select the final verse
        randVerse = rand.Next(5);
        int randFinalVers = randVerse < randIniVers ? randIniVers : randVerse;
        randFinalVers = 4; // borrar


            // Choose the book
            switch(randBook) 
            {
            case 1:
                // Call different constructors if there is a single verse or multiple verses
                Reference johnReference = randIniVers == randFinalVers ? new Reference(bookOfJohn.GetBookName(), 
                                                            bookOfJohn.GetChapter(), 
                                                            randIniVers) : 
                                                            new Reference(bookOfJohn.GetBookName(), 
                                                            bookOfJohn.GetChapter(), 
                                                            randIniVers,
                                                            randFinalVers);
                
                Scripture scripture1 = new Scripture(johnReference, 
                                                    bookOfJohn.GetText(),
                                                    randIniVers,
                                                    randFinalVers);
                while (menuOption != "quit")
                {
                    scripture1.GetRenderedText();
                    
                    Console.Write("Press enter to continue or type 'quit' to finish: ");
                    menuOption = Console.ReadLine();
                    scripture1.HideWords();
                    scripture1.GetRenderedText();
                    if (scripture1.IsCompletelyHidden()) {
                        menuOption = "quit";
                    }
                }
                break;
            case 2:
                // code block
                break;
            default:
                // code block
                break;
            }
  
        // while (menuOption != "quit")
        // {
        //     Console.Write("Press enter to continue or type 'quit' to finish: ");
        //     menuOption = Console.ReadLine();
        // }
    }
}