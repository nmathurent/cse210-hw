    using System;

    // A code template for the prompt generator. The responsibility of a PromptGenerator is 
    // to keeps track of the prompts.


    // Author: Nelson Mathurent
    // Date:   January 20, 2023

    public class PromptGenerator
    {
        // Creating the member variables of the class
        public string[] _prompt = {"Question 1", 
                                    "Question 2",
                                    "Question 3",
                                    "Question 4",
                                    "Question 5"};

        // Journal constructor.
        public PromptGenerator()
        {
        }


        // A method to add and entry to the journal 
        public string GetPrompt(Journal journal)
        {
            // Instantiate random number generator
            // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
            Random rand = new Random();

            Console.WriteLine("Number of entrie in journal: " + journal._entries.Count);
            if (journal._entries.Count >= 5)
            {
                return "All questions have been asked!  Press Enter to continue...";
            }

            string prompt = _prompt[rand.Next(_prompt.Length)];

            // Check if the question was already added to the journal
            // https://stackoverflow.com/questions/4651285/checking-if-a-list-of-objects-contains-a-property-with-a-specific-value
            while (journal._entries.Any(x=>x._prompt==prompt))
            {
                prompt = _prompt[rand.Next(_prompt.Length)];
            }

            return prompt;
            
        }

    }