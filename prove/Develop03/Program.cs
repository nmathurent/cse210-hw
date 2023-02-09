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

        // Choose a ramdom number between 1 and 4 to select a random book
        int randBook = rand.Next(4) == 0 ? 1 : rand.Next(4);
        // randBook = 4;  // borrar

        // Choose a ramdom number between 1 and 5 to select the initial verse
        randVerse = rand.Next(5);
        int randIniVers = randVerse == 0 ? 1 : randVerse;
        // randIniVers = 2; // borrar

        // Choose a ramdom number between 1 and 5 to select the final verse
        randVerse = rand.Next(5);
        int randFinalVers = randVerse < randIniVers ? randIniVers : randVerse;
        // randFinalVers = 2; // borrar


            // Choose the book
            switch(randBook) 
            {
            // Take an scripture from the book of John Chapter 11
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
                ShowScripture(scripture1);
                
                break;

             // Take an scripture from the book of Luke Chapter 2
            case 2:   
                // Call different constructors if there is a single verse or multiple verses
                Reference lukeReference = randIniVers == randFinalVers ? new Reference(bookOfLuke.GetBookName(), 
                                                            bookOfLuke.GetChapter(), 
                                                            randIniVers) : 
                                                            new Reference(bookOfLuke.GetBookName(), 
                                                            bookOfLuke.GetChapter(), 
                                                            randIniVers,
                                                            randFinalVers);
                
                Scripture scripture2 = new Scripture(lukeReference, 
                                                    bookOfLuke.GetText(),
                                                    randIniVers,
                                                    randFinalVers);
                ShowScripture(scripture2);

                break;

            // Take an scripture from the book of Mark Chapter 8
            case 3:   
                // Call different constructors if there is a single verse or multiple verses
                Reference markReference = randIniVers == randFinalVers ? new Reference(bookOfMark.GetBookName(), 
                                                            bookOfMark.GetChapter(), 
                                                            randIniVers) : 
                                                            new Reference(bookOfMark.GetBookName(), 
                                                            bookOfMark.GetChapter(), 
                                                            randIniVers,
                                                            randFinalVers);
                
                Scripture scripture3 = new Scripture(markReference, 
                                                    bookOfMark.GetText(),
                                                    randIniVers,
                                                    randFinalVers);
                ShowScripture(scripture3);

                break;

            // Take an scripture from the book of Mark Chapter 8
            case 4:   
                // Call different constructors if there is a single verse or multiple verses
                Reference matthewReference = randIniVers == randFinalVers ? new Reference(bookOfMatthew.GetBookName(), 
                                                            bookOfMatthew.GetChapter(), 
                                                            randIniVers) : 
                                                            new Reference(bookOfMatthew.GetBookName(), 
                                                            bookOfMatthew.GetChapter(), 
                                                            randIniVers,
                                                            randFinalVers);
                
                Scripture scripture4 = new Scripture(matthewReference, 
                                                    bookOfMatthew.GetText(),
                                                    randIniVers,
                                                    randFinalVers);
                ShowScripture(scripture4);

                break;
            default:
                // code block
                break;
            }
  
        void ShowScripture(Scripture scrip) {
                while (menuOption != "quit")
                {
                    scrip.GetRenderedText();
                    
                    Console.Write("Press enter to continue or type 'quit' to finish: ");
                    menuOption = Console.ReadLine();
                    scrip.HideWords();
                    scrip.GetRenderedText();
                    if (scrip.IsCompletelyHidden()) {
                        menuOption = "quit";
                    }
                }
        }
    }
}