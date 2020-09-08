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

        public void chooseDistinctName()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var distinctNames = names.Distinct();
            foreach(string name in distinctNames)
            {
                Console.WriteLine(name);
            }
        }

        public void classGradeAverage()
        {
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            var averageString = classGrades
                .Select(x => x.Split(','))
                .Select(x => Array.ConvertAll(x, double.Parse))
                .Select(x => (x.Sum() - x.Min()) / (x.Count() - 1))
                .Average();
            Console.WriteLine(averageString);
            Console.ReadLine();
        }
    }
}
