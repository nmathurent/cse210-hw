    using System;

    // A code template for the reference. The responsibility of a 
    // JohnBook is to keeps track of all the verses of the book of John.

    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class JohnBook11
    {
        // Creating the member variables of the class
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        private string[] _text = new string[6];

        // Reference constructor - Single Verse.
        public JohnBook11()
        {
            _book = "John";
            _chapter = 11;
            _startVerse = 1;
            _endVerse = 5;
            _text[1] = "Now a certain man was sick, named Lazarus, of Bethany, the town of Mary and her sister Martha.";
            _text[2] = "It was that Mary which anointed the Lord with ointment, and wiped his feet with her hair, whose brother Lazarus was sick.";
            _text[3] = "Therefore his sisters sent unto him, saying, Lord, behold, he whom thou lovest is sick.";
            _text[4] = "When Jesus heard that, he said, This sickness is not unto death, but for the glory of God, that the Son of God might be glorified thereby.";
            _text[5] = "Now Jesus loved Martha, and her sister, and Lazarus.";
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