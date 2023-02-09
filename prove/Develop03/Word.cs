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
        private string _word;
        private Boolean _isShown;
        private int _wordIndex;


        // Reference constructor - Single Verse.
        public Word(string word, int indexInSentence)
        {
            _word = word;
            _isShown = true;
            _wordIndex = indexInSentence;
        }

        public int GetWordIndex()
        {
            return _wordIndex;
        }

        public Boolean GetIsShown()
        {
            return _isShown;
        }

        public void Hide()
        {
            _isShown = false;
            // https://stackoverflow.com/questions/3624332/how-do-you-remove-all-the-alphabetic-characters-from-a-string
            this._word = Regex.Replace(_word, "[A-Za-z:;,.]", "_");
        }

        public Boolean IsShown()
        {
            return _isShown;
        }

        public string GetRenderedText()
        {
            return this._word;
        }
       

    }