using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool PalindromeTester(string word)
        {
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i].ToString().ToLower();
            }
            if (reversed == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
