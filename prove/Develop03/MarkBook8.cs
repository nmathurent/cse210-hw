    using System;

    // A code template for the reference. The responsibility of a 
    // JohnBook is to keeps track of all the verses of the book of John.

    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class MarkBook8
    {
        // Creating the member variables of the class
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        private string[] _text = new string[6];

        // Reference constructor - Single Verse.
        public MarkBook8()
        {
            _book = "Mark";
            _chapter = 8;
            _startVerse = 1;
            _endVerse = 5;
            _text[1] = "In those days the multitude being very great, and having nothing to eat, Jesus called his disciples unto him, and saith unto them,";
            _text[2] = "I have compassion on the multitude, because they have now been with me three days, and have nothing to eat";
            _text[3] = "And if I send them away fasting to their own houses, they will faint by the way: for divers of them came from far.";
            _text[4] = "And his disciples answered him, From whence can a man satisfy these men with bread here in the wilderness?";
            _text[5] = "And he asked them, How many loaves have ye? And they said, Seven.";
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