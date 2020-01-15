using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace AnagramKata
{
    public class AnagramSelector
    {
        //1. 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 
        //101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199.
        // 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293
        Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'A', 2 },
                {'B', 3 },
                {'C', 5 },
                {'D', 7 },
                {'E', 11 },
                {'F', 13 },
                {'G', 17 },
                {'H', 19 },
                {'I', 23 },
                {'J', 29 },
                {'K', 31 },
                {'L', 37 },
                {'M', 41 },
                {'N', 43 },
                {'O', 47 },
                {'P', 53 },
                {'Q', 59 },
                {'R', 61 },
                {'S', 67 },
                {'T', 71 },
                {'U', 73 },
                {'V', 79 },
                {'W', 83 },
                {'X', 89 },
                {'Y', 97 },
                {'Z', 101 },
                {'Å', 103 },
                {'Ö', 107 },
                {'Ü', 109 },
                {'É', 113 },
                {'\'', 127 },
                {'Á', 131 },
                {'È', 137 },
                {'Ó', 139 },
                {'Ä', 149 },
                {'Ç', 151 },
                {'Ñ', 157 },
                {'Ë', 163 },
                {'Í', 167 },
                {'Â', 173 },
                {'Ô', 179 },
                {'Û', 181 },
                {'Ø', 191 },
                {'Ê', 193 },
                {'Î', 197 },
                {'Ï', 199 },
                {'À', 211 },
                {'Ù', 223 },
                {'Ú', 227 }

            };
        public List<string> Group(List<string> words)
        {
            List<string> result = new List<string>();

            var anagramsGroups = words.GroupBy(x => CharacterProduct(x));
            foreach (var group in anagramsGroups)
            {
                StringBuilder builder = new StringBuilder();
                var distinctGroup = group.Distinct();
                if (distinctGroup.Count() < 2)
                    continue;
                foreach (string word in distinctGroup)
                {
                    builder.Append(word + " ");
                }
                result.Add(builder.ToString());
            }

            return result;
        }

        
        public ulong CharacterProduct(string word)
        {
            
            ulong product = 1;
            string newWord = word.ToUpper();
            for (int i = 0; i < word.Length; i++)
            {
                product *= (ulong)map[newWord[i]];
                
            }

            return product;
        }
    }
}
