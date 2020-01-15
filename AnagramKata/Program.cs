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

            //string w = "Èrbol";
            //string u = w.ToLower();
            //Console.WriteLine(w+u);
            //Console.ReadKey();
            //return;
            string path = $@"WordsFiles\{args[0]}.txt";
            AnagramSelector selector = new AnagramSelector();

            List<string> words = new List<string>();

            try
            {
                words = File.ReadAllLines(path, Encoding.Default).ToList();

            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine($"Error: El archivo {e.FileName} no existe.");
                Console.ReadKey();
                return;
            }
            

            uint setCounter = 1;
            foreach(var set in selector.Group(words))
            {
                Console.WriteLine(setCounter + "- " + set);
                setCounter++;
            }

            Console.ReadKey();
        }
    }
}
