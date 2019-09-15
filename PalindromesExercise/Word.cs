using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromesExercise
{
    public class Word
    {
        public bool RunWord(string word)
        {
            var wordToLower = word.ToLower();
            var setWord = new BuildWord();
            setWord.Word = word;

            string wordAsArr = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            if (wordToLower == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class BuildWord
    {
        public string Word { get; set; }
    }
}
