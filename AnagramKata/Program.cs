using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnagramKata
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "WordsFiles", $"wordlist.txt");
            AnagramSelector selector = new AnagramSelector();

            List<string> words = File.ReadAllLines(path).ToList();
            

            uint setCounter = 1;
            foreach(var set in selector.Group(words))
            {
                Console.WriteLine(setCounter + "- " + set);
            }

            Console.ReadKey();
        }
    }
}
