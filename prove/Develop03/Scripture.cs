    using System;

    // A code template for the scripture. The responsibility of a Journal is 
    // to keeps track of the reference and the text of the scripture.


    // Author: Nelson Mathurent
    // Date:   February 07, 2023

    public class Scripture
    {
        // Creating the member variables of the class
        private Reference _reference;
        private Dictionary<int, string> _verses = new Dictionary<int, string>();
        private string _completeText;
        private List<Word> _listOfWords = new List<Word>();

        // Scripture constructor.
        public Scripture(Reference reference, string[] bookText, int iniVerse, int endVerse)
        {
             _reference = reference;

            for (int i = iniVerse; i <= endVerse; i++) 
            {
                List<Word> listOfWords = new List<Word>();

                _verses.Add(i, bookText[i]);
                _completeText += bookText[i] + "; ";
            }
            _completeText = _completeText.Remove(_completeText.Length - 2, 2);
            

            // Convert the text in a List of Word
            var words = _completeText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int indexInSentence = 0;
            foreach (string wd in words) 
            {
                _listOfWords.Add(new Word(wd, indexInSentence));
                indexInSentence += 1;
            }

        }

        public void HideWords()
        {
            int totalWords = 0;
            int indNextWordToHide;
            // Instantiate random number generator
            // Found in https://www.geeksforgeeks.org/c-sharp-random-next-method/
            Random rand = new Random();

            int[] randWord = {0,0,0};

            // Choose 3 ramdom words to hide
            // https://www.geeksforgeeks.org/c-sharp-check-if-an-array-contain-the-elements-that-match-the-specified-conditions/
            totalWords += _listOfWords.Count();

            while (Array.Exists(randWord, element => element == 0)) {

                FindNextWordToHide(randWord, 0);
                FindNextWordToHide(randWord, 1);
                FindNextWordToHide(randWord, 2);

                if (IsCompletelyHidden()) {
                    break;
                }

             }

             void FindNextWordToHide(int[] arr, int indx) {
                if (arr[indx] == 0) {
                    indNextWordToHide = rand.Next(totalWords);
                    foreach(var word in _listOfWords)
                    {   
                        if (word.GetWordIndex() == indNextWordToHide && word.IsShown()) {
                            arr[indx] = indNextWordToHide;
                            word.Hide();
                        }
                        
                    }
                }
             }
  
        }

        public void GetRenderedText()
        {
            Console.Clear();
            if (_reference.GetStartVerse() == _reference.GetEndVerse()) {
                Console.Write(_reference.DisplaySingleVerse() + " ");
            }
            else {
                Console.Write(_reference.DisplayVerseRange() + " ");
            }
            foreach(var word in _listOfWords) { 
                Console.Write(word.GetRenderedText() + " ");
            }
            Console.WriteLine("\n");
        }

        public Boolean IsCompletelyHidden()
        {
            Boolean isCompletelyHidden = true;

            foreach(var word in _listOfWords)
            {   
                if (word.IsShown() == true) {
                    isCompletelyHidden = false;
                    break;
                }
                        
            }
            return isCompletelyHidden;
        }

    }