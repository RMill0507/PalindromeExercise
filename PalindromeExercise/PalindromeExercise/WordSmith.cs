using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }
        public bool IsAPalindrome(string word)
        {
            var reverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];//reverse = reverse + word at index [i]
            }     
            if (reverse == word)
            {
                return true;    
            }else return false;

        }   
    }

}
