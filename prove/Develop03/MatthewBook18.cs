    using System;

    // A code template for the reference. The responsibility of a 
    // JohnBook is to keeps track of all the verses of the book of John.

    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class MatthewBook18
    {
        // Creating the member variables of the class
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        private string[] _text = new string[6];
        
        // Reference constructor - Single Verse.
        public MatthewBook18()
        {
            _book = "Matthew";
            _chapter = 18;
            _startVerse = 1;
            _endVerse = 5;
            _text[1] = "At the same time came the disciples unto Jesus, saying, Who is the greatest in the kingdom of heaven?";
            _text[2] = "And Jesus called a little child unto him, and set him in the midst of them,";
            _text[3] = "And said, Verily I say unto you, Except ye be converted, and become as little children, ye shall not enter into the kingdom of heaven.";
            _text[4] = "Whosoever therefore shall humble himself as this little child, the same is greatest in the kingdom of heaven.";
            _text[5] = "And whoso shall receive one such little child in my name receiveth me.";
        }

        public string GetBookName()
        {
            return _book;
        }

        public int GetChapter()
        {
            return _chapter;
        }

        public string[] GetText()
        {
            return _text;
        }

    }