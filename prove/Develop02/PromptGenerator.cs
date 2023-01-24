    using System;

    // A code template for the prompt generator. The responsibility of a PromptGenerator is 
    // to keeps track of the prompts.


    // Author: Nelson Mathurent
    // Date:   January 20, 2023

    public class PromptGenerator
    {
        // Creating the member variables of the class
        public string[] _prompt = {"Who was the most interesting person I interacted with today? ", 
                                    "What was the best part of my day? ",
                                    "How did I see the hand of the Lord in my life today? ",
                                    "What was the strongest emotion I felt today? ",
                                    "If I had one thing I could do over today, what would it be? ",
                                    "What services has a stranger already provided for me today? ",
                                    "What could I do more of? And what could I do less of? ",
                                    "What new questions are arising for me in this moment? ",
                                    "What am I grateful for today? ",
                                    "Did I experience any difficulty in my life today? "};

        // PromptGenerator constructor.
        public PromptGenerator()
        {
        }


        // Method used to select a prompt from the list of questions
        public string GetPrompt(Journal journal)
        {
            // Instantiate random number generator
            // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
            Random rand = new Random();

            // Check if all questions have been already asked
            if (journal._entries.Count >= _prompt.Length)
            {
                return "All questions have been asked!  Press Enter to continue...";
            }

            // Select a question using as index a ramdom number from 0 to the maximum number of questions (5)
            string prompt = _prompt[rand.Next(_prompt.Length)];

            // Check if the question was already added to the journal
            // https://stackoverflow.com/questions/4651285/checking-if-a-list-of-objects-contains-a-property-with-a-specific-value
            // Using the following loop to verify if the question has been already included in the journal
            // If the question has not been included yet in the journal then return its value
            while (journal._entries.Any(x=>x._prompt==prompt))
            {
                prompt = _prompt[rand.Next(_prompt.Length)];
            }

            return prompt;
            
        }

    }