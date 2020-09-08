using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class UsingLINQ
    {
        public void returnWordsWithTH()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "tenth", "mathematics" };
            var Words = from word in words
                        where word.Contains("th")
                        select word;
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
