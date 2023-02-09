    using System;
    // RegularExpressions is needed in order to use Regex
    using System.Text.RegularExpressions;

    // A code template for the reference. The responsibility of a 
    // JohnBook is to keeps track of all the verses of the book of John.

    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class Word
    {
        // Creating the member variables of the class
        public string _word;
        public Boolean _isShown;
        public int _wordIndex;

        private char ch1;

        // Reference constructor - Single Verse.
        public Word(string word, int indexInSentence)
        {
            _word = word;
            _isShown = true;
            _wordIndex = indexInSentence;
        }

        public void Hide()
        {
            _isShown = false;
        }

        public Boolean IsHidden()
        {
            return _isShown;
        }

        public string GetRenderedText()
        {
            // https://stackoverflow.com/questions/3624332/how-do-you-remove-all-the-alphabetic-characters-from-a-string
            this._word = Regex.Replace(_word, "[A-Za-z]", "_");
            return this._word;
        }
       

    }