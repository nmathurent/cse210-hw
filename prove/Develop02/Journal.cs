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
            _entries.Add(entryPar);
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
                    outputFile.Write($"\"{indEntry._date}\",\"{indEntry._time}\",");
                    outputFile.WriteLine($"\"{indEntry._prompt}\",\"{indEntry._response}\"");
                }

            }
        }

        // A method that load the journal from a file
        public void Load(string fileNameP)
        {
            // The following line is used to remove all elements from the journal before loading the file
            this._entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(fileNameP);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                // Add statement idea was extracted from the following link
                // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.insert?view=net-7.0
                this.Add(new JournalEntry() { _date = parts[0].Replace("\"", ""), 
                                              _time = parts[1].Replace("\"", ""), 
                                              _prompt = parts[2].Replace("\"", ""), 
                                              _response = parts[3].Replace("\"", "") });

            }
        }
    }