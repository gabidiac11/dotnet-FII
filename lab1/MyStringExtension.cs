using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    public static class MyStringExtension
    {
        public static List<string> GetWordsFromSentence(this string sentence)
        {
            return sentence.Split(' ').ToList();
        }
    }
}
