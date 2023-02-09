    using System;

    // A code template for the reference. The responsibility of a 
    // JohnBook is to keeps track of all the verses of the book of John.

    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class LukeBook2
    {
        // Creating the member variables of the class
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        private string[] _text = new string[6];

        // Reference constructor - Single Verse.
        public LukeBook2()
        {
            _book = "Luke";
            _chapter = 2;
            _startVerse = 1;
            _endVerse = 5;
            _text[1] = "And it came to pass in those days, that there went out a decree from Cæsar Augustus, that all the world should be taxed.";
            _text[2] = "And this taxing was first made when Cyrenius was governor of Syria.";
            _text[3] = "And all went to be taxed, every one into his own city.";
            _text[4] = "And Joseph also went up from Galilee, out of the city of Nazareth, into Judæa, unto the city of David, which is called Bethlehem";
            _text[5] = "To be taxed with Mary his espoused wife, being great with child.";
        }

        // A method that displays the scripture reference - case of a single verse 
        public void Display()
        {
            Console.WriteLine($"{this._book} {this._chapter}:{this._startVerse}");
        }

    }