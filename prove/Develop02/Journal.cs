    using System;

    // A code template for the journal. The responsibility of a Journal is 
    // to keeps track of all the entries in the journal.


    // Author: Nelson Mathurent
    // Date:   January 20, 2023

    public class Journal
    {
        // Creating the member variables of the class
        public List<JournalEntry> _entries = new List<JournalEntry>();

        // Journal constructor.
        public Journal()
        {
        }


        // A method to add and entry to the journal 
        public void Add(JournalEntry entryPar)
        {
            // Console.WriteLine("List before adding the entry");
            // foreach(JournalEntry indEntry in _entries)
            // {
            //     Console.WriteLine(indEntry._prompt);
            // }
            _entries.Add(entryPar);
            // Console.WriteLine("List AFTER adding the entry");
            // foreach(JournalEntry indEntry in _entries)
            // {
            //     Console.WriteLine(indEntry._prompt);
            // }
        }

        // A method that displays all the entries from the journal 
        public void Display()
        {
            foreach(JournalEntry indEntry in _entries)
            {
                indEntry.Display();
                Console.WriteLine("");
            }
        }

         // A method that save the journal to a file
        public void Save(string fileNameP)
        {
            using (StreamWriter outputFile = new StreamWriter(fileNameP))
            {
                
                foreach(JournalEntry indEntry in _entries)
                {
                    // The following line is used to add text to the file
                    outputFile.WriteLine($"Date: {indEntry._date} - Prompt: {indEntry._prompt}");
                    outputFile.WriteLine($"{indEntry._response}");
                    outputFile.WriteLine("");
                }

            }
        }

    }