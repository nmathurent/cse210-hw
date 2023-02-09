    using System;

    // A code template for the reference. The responsibility of a 
    // Reference is to keeps track of the book, chapter, and verse information.

    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class Reference
    {
        // Creating the member variables of the class
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;

        // Reference constructor - Single Verse.
        public Reference(string book, int chapter, int startVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = startVerse;
        }

        // Reference constructor - Verse Range.
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        // A method to get the _startVerse value 
        public int GetStartVerse()
        {
            return _startVerse;
        }

        // A method to get the _endVerse value 
        public int GetEndVerse()
        {
            return _endVerse;
        }

        // A method that displays the scripture reference - case of a single verse 
        public string DisplaySingleVerse()
        {
            return $"{this._book} {this._chapter}:{this._startVerse}";
        }

        // A method that displays the scripture reference - case of a verse range
        public string DisplayVerseRange()
        {
            return $"{this._book} {this._chapter}:{this._startVerse}-{this._endVerse}";
        }


    }