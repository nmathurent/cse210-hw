    using System;

    // A code template for the journal entry. The
    // responsibility of a JournalEntry is to keeps track of the response, 
    // the prompt and the date of one journal entry.

    // Author: Nelson Mathurent
    // Date:   January 20, 2023

    public class JournalEntry
    {
        // Creating the member variables of the class
        public string _date = "";
        public string _prompt = "";
        public string _response = "";

        // JournalEntry constructor.
        public JournalEntry()
        {
            
        }

        // A method that displays the journal entry details 
        public void Display()
        {
            Console.WriteLine($"Date: {this._date} - Prompt: {this._prompt}");
            Console.WriteLine($"{_response}");

        }


    }